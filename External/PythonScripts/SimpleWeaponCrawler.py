import time
from selenium import webdriver
from selenium.webdriver.chrome.options import Options
from selenium.webdriver.chrome.service import Service
from webdriver_manager.chrome import ChromeDriverManager
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from bs4 import BeautifulSoup
from selenium.webdriver.support.ui import Select


def crawl_for_one_weapon(weapon_website):
    data = {}

    # Step 1: Set up chrome
    chrome_options = Options()
    chrome_options.add_argument("--headless")  # 无头模式，不显示浏览器界面
    chrome_options.add_argument("--window-size=1920,1080")
    chrome_options.add_argument("--disable-gpu")
    chrome_options.add_argument("--no-sandbox")
    chrome_options.add_argument('user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36')
    service = Service(ChromeDriverManager().install())
    driver = webdriver.Chrome(service=service, options=chrome_options)

    # Step 2: Try to go to the website
    try:
        # Step 2.1: Go to original website
        driver.get(weapon_website)
        wait = WebDriverWait(driver, 15)
        # Step 2.2: Close setting window
        try:
            time.sleep(0.5)
            close_btn = driver.find_element(
                By.CSS_SELECTOR,
                "div.fixed.inset-0 div.rounded-full.cursor-pointer"
            )
            driver.execute_script("arguments[0].click();", close_btn)
            print("已关闭设置弹窗")
            time.sleep(1)
            pass
        except:
            pass
        # Step 2.3: Consent window
        try:
            consent_btn = wait.until(EC.element_to_be_clickable((By.CSS_SELECTOR, ".fc-cta-consent")))
            consent_btn.click()
            time.sleep(0.5)  # 等遮挡层消失
            print("已关闭Consent窗口")
            pass
        except:
            pass  # 如果没找到弹窗就忽略，继续尝试下面的操作

        # Step 3.1: 获取武器名称
        soup = BeautifulSoup(driver.page_source, "html.parser")
        weapon_name = ""
        h1_tag = soup.find("h1")
        weapon_name = h1_tag.get_text(strip=True)
        data["name"] = weapon_name

        # Step 3.2: 获取武器图片名称
        icon_img = soup.find("img", src=lambda s: s and "UI_EquipIcon" in s)
        raw_src = icon_img.get("src")
        icon_filename = raw_src.split("/")[-1].split("?")[0]
        data["icon"] = icon_filename

        # Step 3.3: 获取武器星级
        rarity = 0

        # 策略：直接找所有含有 'text-amberStarYellow' 类名的 svg 元素
        # 注意：有时候 class 是列表，有时候是字符串，BeautifulSoup 会把 class 解析为列表
        # 我们用 CSS 选择器最快

        # 语法：svg.text-amberStarYellow 表示 class 包含该字符串的 svg
        stars = soup.select("svg.text-amberStarYellow")
        if stars:
            if len(stars) > 0:
                first_star = stars[0]
                star_span = first_star.parent
                if star_span.name == 'span':
                    star_container = star_span.parent
                    real_stars = star_container.select("svg.text-amberStarYellow")
                    rarity = len(real_stars)
                    print(f"定位到星级容器，包含 {rarity} 颗星星")
                    data['rarity'] = rarity
                    pass
                pass
            pass
        else:
            print("未找到带有 'text-amberStarYellow' 的星星")
            pass

        # Step 3.4: 获取精炼说明
        select_element = wait.until(EC.presence_of_element_located((By.CSS_SELECTOR, "select.bg-amberDarkGold")))
        select = Select(select_element)
        for i in range(5):
            try:
                data["p" + str(i + 1)] = ''
                select.select_by_value(str(i))
                time.sleep(0.5)
                progression = driver.find_elements(By.CSS_SELECTOR, "div.font-bold.text-amberBlack.select-text")
                data["p" + str(i + 1)] = progression[0].text
                pass
            except:
                pass
            pass

        # Step 2.4: Click on the Table button
        # 这一段 JS 会寻找所有包含 "Table" 文本的 span，然后向上找它的父级 div 按钮
        found = driver.execute_script("""
                            // 找到所有 span 标签
                            var spans = document.getElementsByTagName('span');
                            for (var i = 0; i < spans.length; i++) {
                                // 如果文本内容去除空格后等于 "Table"
                                if (spans[i].textContent.trim() === 'Table') {
                                    // 找到它的父级元素 (通常按钮是 wrapper)
                                    var parent = spans[i].parentElement;
                                    // 如果父级可点击 (有 cursor-pointer) 或者只是普通的 div，就点它
                                    // 也可以直接点 span 自己，效果通常一样
                                    spans[i].click(); 
                                    return true; // 告诉 Python 找到了
                                }
                            }
                            return false; // 没找到
                        """)
        if found:
            print("JS 点击Table成功！")
        else:
            print("JS 未找到 Table 按钮，尝试截图查看原因...")
            driver.save_screenshot("debug_no_table.png")
        # Step 2.5: Click on the checkbox
        try:
            target_text = "属性"
            # 这里的逻辑是：找到含有该文本的元素，且它是一个可点击的结构 (或者是 label)
            ascension_btn = wait.until(EC.element_to_be_clickable(
                (By.XPATH, f"//*[contains(text(), '{target_text}')]")
            ))
            driver.execute_script("arguments[0].click();", ascension_btn)
            print(f"已点击 '{target_text}'")
            time.sleep(0.5)
            pass
        except:
            pass
        # Step 3.x: Get stat table
        soup = BeautifulSoup(driver.page_source, "html.parser")
        stats_data = []
        all_rows = soup.find_all("tr")
        if not all_rows:
            # 我们尝试直接找 td 的父级
            print("未发现 tr 标签，尝试从 td 反推...")
            # 找到包含 LVL 文字的那个单元格
            lvl_cell = soup.find(lambda t: t.name in ['td', 'th', 'div'] and t.get_text(strip=True) == "LVL")
            if lvl_cell:
                # 找到它所在的行
                header_row = lvl_cell.parent
                # 找到整个表格容器 (可能是 tbody 或 table 或 div)
                table_container = header_row.parent
                # 重新获取所有行
                # recursive=False 只找直接子节点
                all_rows = table_container.find_all(header_row.name, recursive=False)
                pass
            pass
        for row in all_rows:
            # 获取该行内的所有单元格 (td 或 th 或 div)
            # 假设单元格标签和包含 LVL 的那个是一样的，如果不确定就混着找
            cells = row.find_all(['td', 'th', 'div'], recursive=False)
            # 清洗成纯文本列表
            cols_text = [c.get_text(strip=True) for c in cells]
            # 核心判断逻辑：
            # 1. 三列数据
            # 2. 第一列包含数字 (等级)
            if len(cols_text) >= 3:
                level = cols_text[0]
                if any(c.isdigit() for c in level):
                    stats_data.append({
                        "level": level,
                        "base_atk": cols_text[1],
                        "sub_stat": cols_text[2]
                    })
                    pass
                pass
            pass
        if stats_data:
            print(f"成功解析 {len(stats_data)} 条数据")
            data['stats_table'] = stats_data
            pass
        else:
            print("错误：解析结果为空，未找到符合特征的表格行")
            pass
        pass
    except Exception as e:
        print(f"发生错误: {e}")
        driver.save_screenshot("error_snapshot.png")
        pass
    finally:
        driver.quit()
        pass

    return data


def print_to_code(data):
    print('\n\n\n\n')
    print('public static readonly WeaponModel _2xxxxxx = new()')
    print('{')
    print('Rid = 2xxxxxxx,')
    print('Vid = {},'.format(data['Vid']))
    print('Name = \"{}\",'.format(data['name']))
    print('GoodName = xxxx,')
    print('Star = {},'.format(data['rarity']))
    print('ImagePath = \"/Resources/Images/Weapon/{}\",'.format(data['icon']))
    print('AwakenImagePath = \"/Resources/Images/Weapon/{}_Awaken.png\",'.format(data['icon'][:-4]))
    print('WeaponType = Enumeration.WeaponType.Xxxx,')
    print('SubAffix = Enumeration.Affix.Xxxxxxx,')
    print('Progression = {\n' +
          '{1,\"' + data['p1'].replace('\n', '') + '\"},\n' +
          '{2,\"' + data['p2'].replace('\n', '') + '\"},\n' +
          '{3,\"' + data['p3'].replace('\n', '') + '\"},\n' +
          '{4,\"' + data['p4'].replace('\n', '') + '\"},\n' +
          '{5,\"' + data['p5'].replace('\n', '') + '\"},\n' +
          '},')
    print('MainAffixNumberDictionary = new Dictionary<Enumeration.Level, double>(){')
    for kv in data['stats_table']:
        s = '{ Enumeration.Level.L' + str(kv['level']).replace('+', 'P') + ',' + str(kv['base_atk']) + '},'
        print(s, end='')
        if 'Enumeration.Level.L5,' in s:
            print()
            pass
        if 'Enumeration.Level.L10,' in s:
            print()
            pass
        if 'Enumeration.Level.L15,' in s:
            print()
            pass
        if 'Enumeration.Level.L20P,' in s:
            print()
            pass
        if 'Enumeration.Level.L25,' in s:
            print()
            pass
        if 'Enumeration.Level.L30,' in s:
            print()
            pass
        if 'Enumeration.Level.L35,' in s:
            print()
            pass
        if 'Enumeration.Level.L40P,' in s:
            print()
            pass
        if 'Enumeration.Level.L45,' in s:
            print()
            pass
        if 'Enumeration.Level.L50P,' in s:
            print()
            pass
        if 'Enumeration.Level.L55,' in s:
            print()
            pass
        if 'Enumeration.Level.L60P,' in s:
            print()
            pass
        if 'Enumeration.Level.L65,' in s:
            print()
            pass
        if 'Enumeration.Level.L70P,' in s:
            print()
            pass
        if 'Enumeration.Level.L75,' in s:
            print()
            pass
        if 'Enumeration.Level.L80P,' in s:
            print()
            pass
        if 'Enumeration.Level.L85,' in s:
            print()
            pass
        if 'Enumeration.Level.L90,' in s:
            print()
            pass
        pass
    print('},')
    print('SubAffixNumberDictionary = new Dictionary<Enumeration.Level, double>(){')
    for kv in data['stats_table']:
        s = '{ Enumeration.Level.L' + str(kv['level']).replace('+', 'P') + ',' + str(kv['sub_stat']).replace('%', '') + '},'
        print(s, end='')
        if 'Enumeration.Level.L5,' in s:
            print()
            pass
        if 'Enumeration.Level.L10,' in s:
            print()
            pass
        if 'Enumeration.Level.L15,' in s:
            print()
            pass
        if 'Enumeration.Level.L20P,' in s:
            print()
            pass
        if 'Enumeration.Level.L25,' in s:
            print()
            pass
        if 'Enumeration.Level.L30,' in s:
            print()
            pass
        if 'Enumeration.Level.L35,' in s:
            print()
            pass
        if 'Enumeration.Level.L40P,' in s:
            print()
            pass
        if 'Enumeration.Level.L45,' in s:
            print()
            pass
        if 'Enumeration.Level.L50P,' in s:
            print()
            pass
        if 'Enumeration.Level.L55,' in s:
            print()
            pass
        if 'Enumeration.Level.L60P,' in s:
            print()
            pass
        if 'Enumeration.Level.L65,' in s:
            print()
            pass
        if 'Enumeration.Level.L70P,' in s:
            print()
            pass
        if 'Enumeration.Level.L75,' in s:
            print()
            pass
        if 'Enumeration.Level.L80P,' in s:
            print()
            pass
        if 'Enumeration.Level.L85,' in s:
            print()
            pass
        if 'Enumeration.Level.L90,' in s:
            print()
            pass
        pass
    print('},')
    print('LevelUpMaterials =  WeaponLevelUpConstants.GetWeapon' + str(data['rarity']) + 'LevelUpMaterial(MaterialConstants.G304xxxx, MaterialConstants.G303xxxx, MaterialConstants.G309xxxx),')
    print('};')
    pass


if __name__ == '__main__':
    source_webpage = "https://gi.yatta.moe/chs/archive/weapon/15516/golden-frostbound-oath"
    table = crawl_for_one_weapon(source_webpage)
    for k in table.keys():
        print(k, end=" -- ")
        print(table[k])
        pass
    table['Vid'] = source_webpage.split('/')[-2].strip()
    print_to_code(table)
    pass
