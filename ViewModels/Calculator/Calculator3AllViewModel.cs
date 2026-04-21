using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Data;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.Messages;
using HexereiKatepnha.Models.ModelsForViews.Calculator;

namespace HexereiKatepnha.ViewModels.Calculator
{
    public partial class Calculator3AllViewModel : ObservableObject, IRecipient<GoalSimulatorChangeMessage>, IRecipient<BackpackMaterialConfigChangeMessage>
    {
        [ObservableProperty] private int _hour;
        [ObservableProperty] private int _minute;
        [ObservableProperty] private int _second;
        public string ResinImagePath { get; set; } = StringConstants.ResinImagePath;
        public string MergeResinImagePath { get; set; } = StringConstants.MergeResinImagePath;
        [ObservableProperty] private int _resinNum;
        [ObservableProperty] private ObservableCollection<ObservableCollection<string>> _resinHintList = new();
        [ObservableProperty] private ObservableCollection<CalculatorPlanLackMaterialModel> _lackMaterialList = new();
        [ObservableProperty] private ObservableCollection<CalculatorPlanBoss60Model> _boss60List = new();
        [ObservableProperty] private CalculatorPlanStatistics _statistics = new();
        [ObservableProperty] private ObservableCollection<CalculatorPlanDungeon> _dungeonList = new();
        private Dictionary<int, CalculatorPlanMaterial> MaterialRidMap { get; set; } = new();

        public Calculator3AllViewModel()
        {
            UpdateRecoveryCountdown();
            DispatcherTimer timer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += (_, _) => { UpdateRecoveryCountdown(); };
            timer.Start();
            WeakReferenceMessenger.Default.Register<GoalSimulatorChangeMessage>(this);
            WeakReferenceMessenger.Default.Register<BackpackMaterialConfigChangeMessage>(this);
            InitializeDungeonList();
        }

        private void UpdateRecoveryCountdown()
        {
            DateTimeOffset configTime = App.CalculatorPlanSettingConfigManagerInstance!.Configuration.RecoveryTime;
            DateTimeOffset currentTime = DateTimeOffset.Now;
            TimeSpan remainTime = configTime - currentTime;
            if (remainTime.TotalSeconds <= 0)
            {
                Hour = 0;
                Minute = 0;
                Second = 0;
                ResinNum = 200;
                ResinHintList = [["树脂已不再累积，请尽快消耗~"]];
            }
            else if (remainTime.TotalSeconds >= 200 * 8 * 60)
            {
                Hour = 26;
                Minute = 40;
                Second = 0;
                ResinNum = 0;
                DateTimeOffset newConfigTime = currentTime + new TimeSpan(26, 40, 0);
                App.CalculatorPlanSettingConfigManagerInstance.UpdateRecoveryTime(newConfigTime);
                ResinHintList = GetResinHintList();
            }
            else
            {
                Hour = (int)remainTime.TotalHours;
                Minute = remainTime.Minutes;
                Second = remainTime.Seconds;
                double totalMinutes = remainTime.TotalMinutes;
                ResinNum = 200 - (int)Math.Ceiling(totalMinutes / 8);
                ResinHintList = GetResinHintList();
            }
        }

        [RelayCommand]
        private void ClickOnHourUp()
        {
            if (Hour < 26)
            {
                Hour += 1;
                UpdateRecoveryTimeConfig();
            }
        }

        [RelayCommand]
        private void ClickOnHourDown()
        {
            if (Hour > 0)
            {
                Hour -= 1;
                UpdateRecoveryTimeConfig();
            }
        }

        [RelayCommand]
        private void ClickOnMinuteUp()
        {
            if (Minute < 60)
            {
                Minute += 1;
                UpdateRecoveryTimeConfig();
            }
        }

        [RelayCommand]
        private void ClickOnMinuteDown()
        {
            if (Minute > 0)
            {
                Minute -= 1;
                UpdateRecoveryTimeConfig();
            }
        }

        [RelayCommand]
        private void ClickOnSecondUp()
        {
            if (Second < 59)
            {
                Second += 2;
                UpdateRecoveryTimeConfig();
            }
        }

        [RelayCommand]
        private void ClickOnSecondDown()
        {
            if (Second > 0)
            {
                Second -= 1;
                UpdateRecoveryTimeConfig();
            }
        }

        [RelayCommand]
        private void ClickOnResinChange(string value)
        {
            int valueInt = Int32.Parse(value);
            TimeSpan ts = TimeSpan.FromMinutes(-8 * valueInt);
            DateTimeOffset configTime = App.CalculatorPlanSettingConfigManagerInstance!.Configuration.RecoveryTime;
            DateTimeOffset nowTime = DateTimeOffset.Now;
            configTime = nowTime > configTime ? nowTime : configTime;
            DateTimeOffset newTime = configTime + ts;
            DateTimeOffset minTime = DateTimeOffset.Now;
            App.CalculatorPlanSettingConfigManagerInstance.UpdateRecoveryTime(minTime > newTime ? minTime : newTime);
            UpdateRecoveryCountdown();
        }

        private void UpdateRecoveryTimeConfig()
        {
            DateTimeOffset currentTime = DateTimeOffset.Now;
            TimeSpan ts = new TimeSpan(Hour, Minute, Second);
            DateTimeOffset newConfigTime = currentTime + ts;
            App.CalculatorPlanSettingConfigManagerInstance!.UpdateRecoveryTime(newConfigTime);
            UpdateRecoveryCountdown();
        }

        private ObservableCollection<ObservableCollection<string>> GetResinHintList()
        {
            ObservableCollection<ObservableCollection<string>> res = [[], [], [], []];
            DateTimeOffset startTime = App.CalculatorPlanSettingConfigManagerInstance!.Configuration.RecoveryTime;
            DateTimeOffset nowTime = DateTimeOffset.Now;
            int startResinNum = 200;
            while (startTime > nowTime)
            {
                TimeSpan ts = startTime - nowTime;
                int thisHour = (int)ts.TotalHours;
                int thisMinute = ts.Minutes;
                string remainTimeString = "";
                if (thisHour == 0 && thisMinute == 0)
                {
                    remainTimeString = "小于1分钟后";
                }
                else
                {
                    if (thisHour != 0) remainTimeString += $"{thisHour}小时";
                    if (thisMinute != 0) remainTimeString += $"{thisMinute}分钟";
                    remainTimeString += "后";
                }

                res[0].Insert(0, remainTimeString);
                string localTimeString = startTime.ToLocalTime().ToString("HH:mm");
                string serverTimeString = startTime.ToOffset(TimeSpan.FromHours(8)).ToString("HH:mm");
                res[1].Insert(0, localTimeString == serverTimeString ? $"( {serverTimeString} )" : $"( {localTimeString} / {serverTimeString} )");
                res[2].Add("树脂数达到");
                res[3].Insert(0, startResinNum.ToString());
                startTime -= TimeSpan.FromMinutes(8 * 20);
                startResinNum -= 20;
            }

            return res;
        }

        private void InitializeDungeonList()
        {
            foreach (List<DungeonModel> l in AllEntities.AllDungeonLists)
            {
                foreach (DungeonModel m in l)
                {
                    CalculatorPlanDungeon thisModel = new CalculatorPlanDungeon
                    {
                        Rid = m.Rid,
                        Name = m.Name
                    };
                    ObservableCollection<CalculatorPlanMaterial> materialList = new();
                    foreach (MaterialPairModel mpm in m.DropMaterialList)
                    {
                        MaterialModel thisMaterial = (mpm.MaterialModel as MaterialModel)!;
                        CalculatorPlanMaterial thisMaterialModel = new CalculatorPlanMaterial
                        {
                            Rid = thisMaterial.Rid,
                            Name = thisMaterial.Name,
                            BackgroundImagePath = StringConstants.StarBackgroundImagePath[thisMaterial.Star],
                            ImagePath = thisMaterial.ImagePath,
                            Number = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(thisMaterial.Rid),
                            IconPath = StringConstants.CheckCircleIconPath
                        };
                        materialList.Add(thisMaterialModel);
                    }

                    thisModel.DungeonMaterialList = materialList;
                    DungeonList.Add(thisModel);
                }
            }

            UpdatePlanForGoal();
        }

        private void UpdatePlanForGoal()
        {
            LackMaterialList = App.GlobalGoalSimulatorServiceAll!.GetAllLackMaterial();
            Boss60List = App.GlobalGoalSimulatorServiceAll.GetBoss60();
            Statistics = App.GlobalGoalSimulatorServiceAll.GetStatistics();
            UpdateDungeonList();
            MaterialRidMap.Clear();
            foreach (CalculatorPlanDungeon d in DungeonList)
            {
                foreach (CalculatorPlanMaterial m in d.DungeonMaterialList)
                {
                    MaterialRidMap[m.Rid] = m;
                }
            }
        }

        private void UpdateDungeonList()
        {
            Dictionary<int, CalculatorPlanDungeon> calculatedMap = App.GlobalGoalSimulatorServiceAll!.GetDungeon();
            foreach (CalculatorPlanDungeon cpd in DungeonList)
            {
                if (calculatedMap.TryGetValue(cpd.Rid, out var newestCpd))
                {
                    if (newestCpd.TimeString != cpd.TimeString) cpd.TimeString = newestCpd.TimeString;
                    if (newestCpd.ResinString != cpd.ResinString) cpd.ResinString = newestCpd.ResinString;
                    if (newestCpd.ResinImagePath != cpd.ResinImagePath) cpd.ResinImagePath = newestCpd.ResinImagePath;
                    if (newestCpd.DayString != cpd.DayString) cpd.DayString = newestCpd.DayString;
                    Dictionary<int, CalculatorPlanMaterial> newestDungeonMaterialMap = newestCpd.DungeonMaterialList.ToDictionary(m => m.Rid, m => m);
                    foreach (CalculatorPlanMaterial cpm in cpd.DungeonMaterialList)
                    {
                        CalculatorPlanMaterial newestCpm = newestDungeonMaterialMap[cpm.Rid];
                        if (newestCpm.Number != cpm.Number) cpm.Number = newestCpm.Number;
                        if (newestCpm.Num1 != cpm.Num1) cpm.Num1 = newestCpm.Num1;
                        if (newestCpm.Color1 != cpm.Color1) cpm.Color1 = newestCpm.Color1;
                        if (newestCpm.IconPath != cpm.IconPath) cpm.IconPath = newestCpm.IconPath;
                        if (newestCpm.Num2String != cpm.Num2String) cpm.Num2String = newestCpm.Num2String;
                        if (newestCpm.Color2 != cpm.Color2) cpm.Color2 = newestCpm.Color2;
                    }

                    // 处理DungeonItemList
                    // 先把现在的部分弄到一样长
                    if (cpd.DungeonItemList.Count < newestCpd.DungeonItemList.Count)
                    {
                        for (int i = cpd.DungeonItemList.Count; i < newestCpd.DungeonItemList.Count; i++)
                        {
                            cpd.DungeonItemList.Add(newestCpd.DungeonItemList[i]);
                        }
                    }

                    if (cpd.DungeonItemList.Count > newestCpd.DungeonItemList.Count)
                    {
                        for (int i = cpd.DungeonItemList.Count - 1; i >= newestCpd.DungeonItemList.Count; i--)
                        {
                            cpd.DungeonItemList.RemoveAt(i);
                        }
                    }

                    // 再修改内部图片
                    for (int i = 0; i < cpd.DungeonItemList.Count; i++)
                    {
                        CalculatorPlanItem cpi = cpd.DungeonItemList[i];
                        CalculatorPlanItem newestCpi = newestCpd.DungeonItemList[i];
                        if (newestCpi.Name != cpi.Name) cpi.Name = newestCpi.Name;
                        if (newestCpi.BackgroundImagePath != cpi.BackgroundImagePath) cpi.BackgroundImagePath = newestCpi.BackgroundImagePath;
                        if (newestCpi.ImagePath != cpi.ImagePath) cpi.ImagePath = newestCpi.ImagePath;
                    }

                    if (!cpd.IsVisible) cpd.IsVisible = true;
                }
                else
                {
                    if (cpd.IsVisible) cpd.IsVisible = false;
                }
            }
        }

        public void Receive(GoalSimulatorChangeMessage message)
        {
            UpdatePlanForGoal();
        }

        [RelayCommand]
        private void AddOneMaterial(CalculatorPlanMaterial? clickItem)
        {
            if (clickItem != null)
            {
                App.BackpackMaterialConfigManagerInstance!.UpdateMaterialNumber(clickItem.Rid, clickItem.Number + 1);
            }
        }

        [RelayCommand]
        private void MinusOneMaterial(CalculatorPlanMaterial? clickItem)
        {
            if (clickItem is { Number: >= 1 })
            {
                App.BackpackMaterialConfigManagerInstance!.UpdateMaterialNumber(clickItem.Rid, clickItem.Number - 1);
            }
        }

        [RelayCommand]
        private void MergeOneMaterial(CalculatorPlanMaterial? clickItem)
        {
            if (clickItem != null)
            {
                int recipeId = AutoCalculateConstants.MaterialMergeRecipe[clickItem.Rid];
                CalculatorPlanMaterial recipeMaterial = MaterialRidMap[recipeId];
                if (recipeMaterial.Number >= 3)
                {
                    App.BackpackMaterialConfigManagerInstance!.UpdateMaterialNumber([recipeMaterial.Rid, clickItem.Rid], [recipeMaterial.Number - 3, clickItem.Number + 1]);
                }
            }
        }

        [RelayCommand]
        public void OpenHelpWebPage()
        {
            string url = "https://github.com/TimmyTim-101/HexereiKatepnha/wiki/%E8%AE%A1%E7%AE%97%E5%99%A8-%E2%80%90-%E5%85%A8%E6%8B%89%E6%BB%A1";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Receive(BackpackMaterialConfigChangeMessage message)
        {
            List<int> materialRidList = message.Value;
            foreach (int materialRid in materialRidList)
            {
                if (MaterialRidMap.TryGetValue(materialRid, out CalculatorPlanMaterial? thisMaterialItem))
                {
                    thisMaterialItem.Number = App.BackpackMaterialConfigManagerInstance!.GetMaterialNumber(materialRid);
                }
            }
        }
    }
}