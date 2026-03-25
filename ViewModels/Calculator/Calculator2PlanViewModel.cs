using System.Collections.ObjectModel;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HexereiKatepnha.ViewModels.Calculator
{
    public partial class Calculator2PlanViewModel : ObservableObject
    {
        [ObservableProperty] private int _hour;
        [ObservableProperty] private int _minute;
        [ObservableProperty] private int _second;
        public string ResinImagePath { get; set; } = "/Resources/Icons/UI_ItemIcon_106.png";
        [ObservableProperty] private int _resinNum;
        [ObservableProperty] private ObservableCollection<ObservableCollection<string>> _resinHintList = new();

        public Calculator2PlanViewModel()
        {
            UpdateRecoveryCountdown();
            DispatcherTimer timer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += (_, _) => { UpdateRecoveryCountdown(); };
            timer.Start();
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
                if (localTimeString == serverTimeString)
                {
                    res[1].Insert(0, $"({serverTimeString})");
                }
                else
                {
                    res[1].Insert(0, $"({localTimeString} / {serverTimeString})");
                }

                res[2].Add("树脂数达到");
                res[3].Insert(0, startResinNum.ToString());
                startTime -= TimeSpan.FromMinutes(8 * 20);
                startResinNum -= 20;
            }

            return res;
        }
    }
}