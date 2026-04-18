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

affix_string_map = {'基础生命值': 'Enumeration.Affix.Health', '基础攻击力': 'Enumeration.Affix.Attack', '基础防御力': 'Enumeration.Affix.Defense', '岩元素伤害加成': 'Enumeration.Affix.GeoDamage', '暴击伤害': 'Enumeration.Affix.CriticalDamage', '元素精通': 'Enumeration.Affix.ElementalMastery',
                    '暴击率': 'Enumeration.Affix.CriticalRate', '治疗加成': 'Enumeration.Affix.AdditionalHealing', '攻击力': 'Enumeration.Affix.AttackPercent', '生命值': 'Enumeration.Affix.HealthPercent', '防御力': 'Enumeration.Affix.DefensePercent',
                    '风元素伤害加成': 'Enumeration.Affix.AnemoDamage', '草元素伤害加成': 'Enumeration.Affix.DendroDamage', '元素充能效率': 'Enumeration.Affix.EnergyRecharge', '水元素伤害加成': 'Enumeration.Affix.HydroDamage', '冰元素伤害加成': 'Enumeration.Affix.CryoDamage',
                    '火元素伤害加成': 'Enumeration.Affix.PyroDamage', '物理伤害加成': 'Enumeration.Affix.PhysicalDamage', '雷元素伤害加成': 'Enumeration.Affix.ElectroDamage'}

element_material_group_name = {
    'Rock': 'G3070801',
    'Wind': 'G3070601',
    'Water': 'G3070301',
    'Fire': 'G3070201',
    'Grass': 'G3070401',
    'Electric': 'G3070501',
    'Ice': 'G3070701',
}


def get_level(s):
    p_flag = False
    if '+' in s:
        p_flag = True
        pass
    res = 'Enumeration.Level.L'
    res += s.replace('+', '')
    if p_flag:
        res += 'P'
        pass
    return res


def crawl_for_one_character(character_website):
    data = {}
    # 设置Chrome
    chrome_options = Options()
    chrome_options.add_argument("--headless")  # 无头模式，不显示浏览器界面
    chrome_options.add_argument("--window-size=1920,1080")
    chrome_options.add_argument("--disable-gpu")
    chrome_options.add_argument("--no-sandbox")
    chrome_options.add_argument('user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36')
    service = Service(ChromeDriverManager().install())
    driver = webdriver.Chrome(service=service, options=chrome_options)
    # 尝试获取数据
    try:
        # 进入网页
        driver.get(character_website)
        wait = WebDriverWait(driver, 15)
        # 关闭弹窗
        try:
            time.sleep(0.5)
            close_btn = driver.find_element(
                By.CSS_SELECTOR,
                "div.fixed.inset-0 div.rounded-full.cursor-pointer"
            )
            driver.execute_script("arguments[0].click();", close_btn)
            # print("已关闭设置弹窗")
            time.sleep(1)
            pass
        except:
            pass
        # 获取信息同意
        try:
            consent_btn = wait.until(EC.element_to_be_clickable((By.CSS_SELECTOR, ".fc-cta-consent")))
            consent_btn.click()
            time.sleep(0.5)  # 等遮挡层消失
            # print("已关闭Consent窗口")
            pass
        except:
            pass
        with open('c1.html', 'w', encoding='utf-8') as f:
            f.write(driver.page_source)
            pass
        # 1、获取名称
        soup = BeautifulSoup(driver.page_source, "html.parser")
        character_name = ""
        h1_tag = soup.find("h1")
        character_name = h1_tag.get_text(strip=True)
        data["name"] = character_name
        # 2、获取元素类型
        element_img = soup.find("img", src=lambda s: s and "Buff_Element" in s)
        raw_src = element_img.get("src")
        element_name = raw_src.split("/")[-1].split("?")[0]
        element_name = element_name.split('.')[0].split('_')[-1]
        data['element'] = element_name
        # 3、获取武器类型
        weapon_img = soup.find("img", src=lambda s: s and "GachaTypeIcon" in s)
        raw_src = weapon_img.get("src")
        weapon_name = raw_src.split("/")[-1].split("?")[0]
        weapon_name = weapon_name.split('.')[0].split('_')[-1]
        data['weapon'] = weapon_name
        # 4、获取生日
        birthday_label = soup.find('td', string=lambda s: s and '生日' in s)
        birthday_value = birthday_label.find_next_sibling('td').text.strip()
        data['b_month'] = birthday_value.split('/')[0]
        data['b_day'] = birthday_value.split('/')[1]
        # 5、获取属性
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
            # print("JS 点击Table成功！")
            pass
        else:
            print("JS 未找到 Table 按钮，尝试截图查看原因...")
            driver.save_screenshot("debug_no_table.png")
            pass
        # 6、获取星级
        stars = soup.select("svg.text-yellow-600")
        if stars:
            if len(stars) > 0:
                first_star = stars[0]
                star_span = first_star.parent
                if star_span.name == 'span':
                    star_container = star_span.parent.parent
                    real_stars = star_container.select("svg.text-yellow-600")
                    rarity = len(real_stars)
                    # print(f"定位到星级容器，包含 {rarity} 颗星星")
                    data['rarity'] = rarity
                    pass
                pass
            pass
        else:
            print("未找到带有 'text-amberStarYellow' 的星星")
            pass
        # Step 2.5: Click on the checkbox
        try:
            target_text = "属性"
            # 这里的逻辑是：找到含有该文本的元素，且它是一个可点击的结构 (或者是 label)
            ascension_btn = wait.until(EC.element_to_be_clickable(
                (By.XPATH, f"//*[contains(text(), '{target_text}')]")
            ))
            driver.execute_script("arguments[0].click();", ascension_btn)
            # print(f"已点击 '{target_text}'")
            time.sleep(0.5)
            pass
        except:
            pass
        with open('c2.html', 'w', encoding='utf-8') as f:
            f.write(driver.page_source)
            pass
        soup = BeautifulSoup(driver.page_source, "html.parser")
        stats_data = []
        target_table = soup.find('table', class_='stat-table w-full text-center')
        tbody = target_table.find('tbody')
        header_tds = tbody.find_all('td', recursive=False)
        headers = [td.get_text(strip=True) for td in header_tds]
        stats_data.append(headers)
        rows = target_table.find_all('tr')
        for row in rows:
            cols = row.find_all('td')
            row_data = [col.get_text(strip=True) for col in cols]
            stats_data.append(row_data)
            pass
        data['stat_data'] = stats_data
        target_button = wait.until(EC.element_to_be_clickable((By.CSS_SELECTOR, "div[name='title'] div[name='Button'] > div")))
        target_button.click()
        # driver.save_screenshot("after_click_button.png")
        driver.get(character_website + '?mode=talent')
        wait = WebDriverWait(driver, 15)
        with open('c3.html', 'w', encoding='utf-8') as f:
            f.write(driver.page_source)
            pass
        # 1、获取天赋
        soup = BeautifulSoup(driver.page_source, "html.parser")
        skill_a_img = soup.find("img", src=lambda s: s and "Skill_A" in s)
        raw_src = skill_a_img.get("src")
        skill_a_img_name = raw_src.split("/")[-1].split("?")[0]
        data['skill_a_img'] = skill_a_img_name
        skill_a_name = skill_a_img.find_next_sibling('div').text.strip()
        data['skill_a'] = skill_a_name
        skill_s_img = soup.find("img", src=lambda s: s and "Skill_S" in s)
        raw_src = skill_s_img.get("src")
        skill_s_img_name = raw_src.split("/")[-1].split("?")[0]
        data['skill_s_img'] = skill_s_img_name
        skill_s_name = skill_s_img.find_next_sibling('div').text.strip()
        skill_s_name = skill_s_name.replace('E.', '').strip()
        data['skill_s'] = skill_s_name
        skill_e_img = soup.find("img", src=lambda s: s and "Skill_E" in s)
        raw_src = skill_e_img.get("src")
        skill_e_img_name = raw_src.split("/")[-1].split("?")[0]
        data['skill_e_img'] = skill_e_img_name
        skill_e_name = skill_e_img.find_next_sibling('div').text.strip()
        skill_e_name = skill_e_name.replace('Q.', '').strip()
        data['skill_e'] = skill_e_name
        driver.get(character_website + '?mode=constellation')
        wait = WebDriverWait(driver, 15)
        with open('c4.html', 'w', encoding='utf-8') as f:
            f.write(driver.page_source)
            pass
        # 1、获取命座
        soup = BeautifulSoup(driver.page_source, "html.parser")
        ascension = soup.find('h2', string=lambda s: s and '命之座' in s)

        a1_img = ascension.find_next('img')
        a1_img_src = a1_img.get('src')
        a1_img_name = a1_img_src.split("/")[-1].split("?")[0]
        data['a1_img'] = a1_img_name
        a1_str_label = a1_img.find_next('div', class_='mr-auto font-whitney lg:text-lg xl:text-xl')
        data['a1_str'] = a1_str_label.text.replace('1.', '').strip()

        english_name = a1_img_name.split('.')[0].split('_')[-2]
        data['ename'] = english_name

        a2_img = a1_str_label.find_next('img')
        a2_img_src = a2_img.get('src')
        a2_img_name = a2_img_src.split("/")[-1].split("?")[0]
        data['a2_img'] = a2_img_name
        a2_str_label = a2_img.find_next('div', class_='mr-auto font-whitney lg:text-lg xl:text-xl')
        data['a2_str'] = a2_str_label.text.replace('2.', '').strip()

        a3_img = a2_str_label.find_next('img')
        a3_img_src = a3_img.get('src')
        a3_img_name = a3_img_src.split("/")[-1].split("?")[0]
        data['a3_img'] = a3_img_name
        a3_str_label = a3_img.find_next('div', class_='mr-auto font-whitney lg:text-lg xl:text-xl')
        data['a3_str'] = a3_str_label.text.replace('3.', '').strip()

        a4_img = a3_str_label.find_next('img')
        a4_img_src = a4_img.get('src')
        a4_img_name = a4_img_src.split("/")[-1].split("?")[0]
        data['a4_img'] = a4_img_name
        a4_str_label = a4_img.find_next('div', class_='mr-auto font-whitney lg:text-lg xl:text-xl')
        data['a4_str'] = a4_str_label.text.replace('4.', '').strip()

        a5_img = a4_str_label.find_next('img')
        a5_img_src = a5_img.get('src')
        a5_img_name = a5_img_src.split("/")[-1].split("?")[0]
        data['a5_img'] = a5_img_name
        a5_str_label = a5_img.find_next('div', class_='mr-auto font-whitney lg:text-lg xl:text-xl')
        data['a5_str'] = a5_str_label.text.replace('5.', '').strip()

        a6_img = a5_str_label.find_next('img')
        a6_img_src = a6_img.get('src')
        a6_img_name = a6_img_src.split("/")[-1].split("?")[0]
        data['a6_img'] = a6_img_name
        a6_str_label = a6_img.find_next('div', class_='mr-auto font-whitney lg:text-lg xl:text-xl')
        data['a6_str'] = a6_str_label.text.replace('6.', '').strip()

        pass
    except Exception as e:
        # print(f"发生错误: {e}")
        # driver.save_screenshot("error_snapshot.png")
        pass
    finally:
        driver.quit()
        pass

    return data


def print_to_code(data):
    if len(data) < 2:
        return
    print('public static CharacterModel _101xxxx = new (){')
    print('Rid = xxxx,')
    print('Vid = {},'.format(data['Vid']))
    print('Name = "{}",'.format(data['name']))
    print('GoodName = xxxx,')
    print('Star = {},'.format(data['rarity']))
    print('ImagePath = \"/Resources/Images/Character/UI_AvatarIcon_{}.png\",'.format(data['ename']))
    print('ElementType = Enumeration.ElementType.', end='')
    if data['element'] == 'Rock':
        print('Geo,')
        pass
    elif data['element'] == 'Wind':
        print('Anemo,')
        pass
    elif data['element'] == 'Water':
        print('Hydro,')
        pass
    elif data['element'] == 'Fire':
        print('Pyro,')
        pass
    elif data['element'] == 'Grass':
        print('Dendro,')
        pass
    elif data['element'] == 'Electric':
        print('Electro,')
        pass
    elif data['element'] == 'Ice':
        print('Cryo,')
        pass
    print('WeaponType = Enumeration.WeaponType.{},'.format(data['weapon']))
    print('BirthMonth = {},'.format(data['b_month']))
    print('BirthDay = {},'.format(data['b_day']))
    print('Talent = new Dictionary<int, ImageDescriptionPairModel>(){')
    print('{{1, new ImageDescriptionPairModel() {{ ImagePath = \"/Resources/Images/CharacterSkillTalent/{}\", Description = \"{}\" }} }},'.format(data['skill_a_img'], data['skill_a']))
    print('{{2, new ImageDescriptionPairModel() {{ ImagePath = \"/Resources/Images/CharacterSkillTalent/{}\", Description = \"{}\" }} }},'.format(data['skill_s_img'], data['skill_s']))
    print('{{3, new ImageDescriptionPairModel() {{ ImagePath = \"/Resources/Images/CharacterSkillTalent/{}\", Description = \"{}\" }} }},'.format(data['skill_e_img'], data['skill_e']))
    print('},')
    print('Ascension = new Dictionary<int, ImageDescriptionPairModel>(){')
    print('{{1, new ImageDescriptionPairModel() {{ ImagePath = \"/Resources/Images/CharacterSkillTalent/{}\", Description = \"{}\" }} }},'.format(data['a1_img'], data['a1_str']))
    print('{{2, new ImageDescriptionPairModel() {{ ImagePath = \"/Resources/Images/CharacterSkillTalent/{}\", Description = \"{}\" }} }},'.format(data['a2_img'], data['a2_str']))
    print('{{3, new ImageDescriptionPairModel() {{ ImagePath = \"/Resources/Images/CharacterSkillTalent/{}\", Description = \"{}\" }} }},'.format(data['a3_img'], data['a3_str']))
    print('{{4, new ImageDescriptionPairModel() {{ ImagePath = \"/Resources/Images/CharacterSkillTalent/{}\", Description = \"{}\" }} }},'.format(data['a4_img'], data['a4_str']))
    print('{{5, new ImageDescriptionPairModel() {{ ImagePath = \"/Resources/Images/CharacterSkillTalent/{}\", Description = \"{}\" }} }},'.format(data['a5_img'], data['a5_str']))
    print('{{6, new ImageDescriptionPairModel() {{ ImagePath = \"/Resources/Images/CharacterSkillTalent/{}\", Description = \"{}\" }} }},'.format(data['a6_img'], data['a6_str']))
    print('},')
    print('AffixDictionary = new Dictionary<Enumeration.Level, Dictionary<Enumeration.Affix, double>>(){')
    beginning_list = []
    row_1_data = data['stat_data'][0]
    for i in range(1, len(row_1_data)):
        this_string = row_1_data[i]
        this_affix = affix_string_map[this_string]
        beginning_list.append(this_affix)
        pass
    for i in range(1, len(data['stat_data'])):
        this_str = "{"
        this_level = data['stat_data'][i][0]
        this_str += get_level(this_level) + ', new Dictionary<Enumeration.Affix, double>() {'
        for j in range(len(beginning_list)):
            this_str += '{{ {},{}}},'.format(beginning_list[j], data['stat_data'][i][j + 1].replace('%', ''))
            pass
        if affix_string_map['暴击伤害'] not in beginning_list:
            this_str += '{{ {},50.0 }},'.format(affix_string_map['暴击伤害'])
            pass
        if affix_string_map['暴击率'] not in beginning_list:
            this_str += '{{ {},5.0 }},'.format(affix_string_map['暴击率'])
            pass
        this_str += '}},'
        print(this_str)
        pass
    print('},')
    print('LevelUpMaterials = CharacterLevelUpConstants.GetCharacterLevelUpMaterial(MaterialConstants._310xxxx, MaterialConstants._306xxxx, MaterialConstants.{}, MaterialConstants.G304xxxx),'.format(element_material_group_name[data['element']]))
    print('Talent1Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants._305xxxx, MaterialConstants.G304xxxx, MaterialConstants.G308xxxx),')
    print('Talent2Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants._305xxxx, MaterialConstants.G304xxxx, MaterialConstants.G308xxxx),')
    print('Talent3Materials = CharacterLevelUpConstants.GetCharacterTalentMaterial(MaterialConstants._305xxxx, MaterialConstants.G304xxxx, MaterialConstants.G308xxxx),')
    print('};')
    pass


def process_one_character(cid):
    source_webpage = "https://gi.yatta.moe/chs/archive/avatar/" + str(cid)
    table = crawl_for_one_character(source_webpage)
    for k in table.keys():
        # print(k, end=" -- ")
        # print(table[k])
        pass
    vid = int(source_webpage.split('/')[-1].strip())
    # vid_1000 = vid % 1000
    # if vid_1000 >= 100:
    #     vid = 4000 + vid_1000
    #     pass
    # else:
    #     vid = 1000 + vid_1000
    #     pass
    # print('Vid -- {}'.format(vid))
    table['Vid'] = str(vid)
    print_to_code(table)
    pass


if __name__ == '__main__':
    print()
    print()
    for cid in range(10000130, 10000131):
        if cid == 10000117:
            continue
            pass
        if cid == 10000118:
            continue
            pass
        process_one_character(cid)
        print()
        print()
        print()
        print()
        print()
        pass
    pass
