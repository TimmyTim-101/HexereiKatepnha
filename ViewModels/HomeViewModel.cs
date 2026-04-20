using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews;
using HexereiKatepnha.Services.ConfigService;

namespace HexereiKatepnha.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty] private string _localCurrentTime;
        [ObservableProperty] private string _serverCurrentTime;
        [ObservableProperty] private int _birthday;
        [ObservableProperty] private bool _isServerTimeSame;
        [ObservableProperty] private bool _isServerTimeDifferent;
        [ObservableProperty] private string _currentAccount;
        [ObservableProperty] private string _newAccountName = "";
        [ObservableProperty] private string _renameAccountName = "";
        [ObservableProperty] private ObservableCollection<string> _allAccountList = [];
        public ObservableCollection<BirthdayCharacterModel> BirthdayList { get; set; } = [];
        private DateTime _lastCheckDate;

        public HomeViewModel()
        {
            LocalCurrentTime = DateTime.Now.ToString("HH:mm:ss");
            ServerCurrentTime = DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(8)).ToString("HH:mm:ss");
            Birthday = DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(8)).Month * 100 + DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(8)).Day;
            _lastCheckDate = DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(8)).Date;
            IsServerTimeSame = LocalCurrentTime == ServerCurrentTime;
            IsServerTimeDifferent = !IsServerTimeSame;

            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += (_, _) =>
            {
                LocalCurrentTime = DateTime.Now.ToString("HH:mm:ss");
                ServerCurrentTime = DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(8)).ToString("HH:mm:ss");
                Birthday = DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(8)).Month * 100 + DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(8)).Day;
                IsServerTimeSame = LocalCurrentTime == ServerCurrentTime;
                IsServerTimeDifferent = !IsServerTimeSame;
                DateTime currentDate = DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(8)).Date;
                if (currentDate != _lastCheckDate)
                {
                    _lastCheckDate = currentDate;
                    UpdateBirthdayList();
                }
            };
            timer.Start();

            CurrentAccount = App.AccountConfigManagerInstance!.Configuration.CurrentAccount;
            AllAccountList.Clear();
            for (int i = 0; i < App.AccountConfigManagerInstance.Configuration.AccountList.Count; i++)
            {
                AllAccountList.Add(App.AccountConfigManagerInstance.Configuration.AccountList[i]);
            }

            UpdateBirthdayList();
        }

        private void UpdateBirthdayList()
        {
            BirthdayList.Clear();
            int currentBirthday = Birthday;
            while (BirthdayList.Count < 15)
            {
                if (AutoCalculateConstants.CharacterBirthdayDictionary.ContainsKey(currentBirthday))
                {
                    foreach (CharacterModel cm in AutoCalculateConstants.CharacterBirthdayDictionary[currentBirthday])
                    {
                        BirthdayCharacterModel thisBirthdayCharacterModel = new BirthdayCharacterModel();
                        thisBirthdayCharacterModel.ImagePath = cm.ImagePath;
                        thisBirthdayCharacterModel.BackgroundPath = StringConstants.StarBackgroundImagePath[cm.Star];
                        thisBirthdayCharacterModel.StarImagePath = StringConstants.StarImagePath[cm.Star];
                        thisBirthdayCharacterModel.ElementImagePath = StringConstants.ElementTypeImagePath[cm.ElementType];
                        thisBirthdayCharacterModel.Name = cm.Name;
                        thisBirthdayCharacterModel.BirthdayString = cm.BirthMonth + "/" + cm.BirthDay;
                        if (currentBirthday == 229)
                        {
                            int currentYear = DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(8)).Year;
                            if (DateTime.IsLeapYear(currentYear))
                            {
                                thisBirthdayCharacterModel.IsTodayBirthday = Birthday == cm.BirthMonth * 100 + cm.BirthDay;
                                thisBirthdayCharacterModel.IsNotTodayBirthday = Birthday != cm.BirthMonth * 100 + cm.BirthDay;
                            }
                            else
                            {
                                thisBirthdayCharacterModel.IsTodayBirthday = Birthday == cm.BirthMonth * 100 + cm.BirthDay - 1;
                                thisBirthdayCharacterModel.IsNotTodayBirthday = Birthday != cm.BirthMonth * 100 + cm.BirthDay - 1;
                            }
                        }
                        else
                        {
                            thisBirthdayCharacterModel.IsTodayBirthday = Birthday == cm.BirthMonth * 100 + cm.BirthDay;
                            thisBirthdayCharacterModel.IsNotTodayBirthday = Birthday != cm.BirthMonth * 100 + cm.BirthDay;
                        }

                        BirthdayList.Add(thisBirthdayCharacterModel);
                    }
                }

                currentBirthday++;
                if (currentBirthday == 1232)
                {
                    currentBirthday = 101;
                }
            }
        }

        [RelayCommand]
        private void AddAccount()
        {
            if (string.IsNullOrWhiteSpace(NewAccountName)) return;
            if (App.AccountConfigManagerInstance!.Configuration.AccountList.Contains(NewAccountName)) return;
            App.AccountConfigManagerInstance.Configuration.AccountList.Add(NewAccountName);
            NewAccountName = "";
            AllAccountList.Clear();
            for (int i = 0; i < App.AccountConfigManagerInstance.Configuration.AccountList.Count; i++)
            {
                AllAccountList.Add(App.AccountConfigManagerInstance.Configuration.AccountList[i]);
            }

            App.AccountConfigManagerInstance.Save();
            App.AccountConfigManagerInstance.Load();
        }

        private void AddAccountDefault()
        {
            App.AccountConfigManagerInstance!.Configuration.AccountList.Add("默认账号");
            AllAccountList.Clear();
            for (int i = 0; i < App.AccountConfigManagerInstance.Configuration.AccountList.Count; i++)
            {
                AllAccountList.Add(App.AccountConfigManagerInstance.Configuration.AccountList[i]);
            }

            App.AccountConfigManagerInstance.Save();
            App.AccountConfigManagerInstance.Load();
        }

        [RelayCommand]
        private void SwitchAccount(string account)
        {
            if (account == App.AccountConfigManagerInstance!.Configuration.CurrentAccount) return;
            // 切账号前保存
            App.AccountConfigManagerInstance.Save();
            AccountConfigSave();

            // 切换账号
            App.AccountConfigManagerInstance.UpdateCurrentAccount(account);
            Guid currentAccountGuid = AccountConfig.CalculateMd5(account);
            AccountConfigCreate(currentAccountGuid);
            // 重新加载配置
            AccountConfigLoad();
            // 更新本地变量
            CurrentAccount = account;
            AllAccountList.Clear();
            for (int i = 0; i < App.AccountConfigManagerInstance.Configuration.AccountList.Count; i++)
            {
                AllAccountList.Add(App.AccountConfigManagerInstance.Configuration.AccountList[i]);
            }

            Restart();
        }

        [RelayCommand]
        private void DeleteAccount(string account)
        {
            // 删除前保存
            App.AccountConfigManagerInstance!.Save();
            AccountConfigSave();
            // 判断是否只有一个默认账号
            Guid accountGuid = AccountConfig.CalculateMd5(account);
            string accountConfigFolder = "Configs/" + accountGuid;
            if (account == "默认账号" && App.AccountConfigManagerInstance.Configuration.AccountList.Count == 1)
            {
                // 是的话只清空就行，不涉及AccountConfig变化
                if (Directory.Exists(accountConfigFolder))
                {
                    Directory.Delete(accountConfigFolder, true);
                }

                AccountConfigCreate(accountGuid);
            }
            else
            {
                // 否的话看能不能切别的账号
                // 不能的话新建一个默认账号
                if (App.AccountConfigManagerInstance.Configuration.AccountList.Count == 1)
                {
                    AddAccountDefault();
                }

                // 切换账号
                string nextAccount = App.AccountConfigManagerInstance.Configuration.AccountList[0];
                for (int i = 0; i < App.AccountConfigManagerInstance.Configuration.AccountList.Count; i++)
                {
                    if (App.AccountConfigManagerInstance.Configuration.AccountList[i] != account)
                    {
                        nextAccount = App.AccountConfigManagerInstance.Configuration.AccountList[i];
                        break;
                    }
                }

                App.AccountConfigManagerInstance.Save();
                AccountConfigSave();
                App.AccountConfigManagerInstance.UpdateCurrentAccount(nextAccount);
                Guid nextAccountGuid = AccountConfig.CalculateMd5(nextAccount);
                AccountConfigCreate(nextAccountGuid);
                AccountConfigLoad();
                CurrentAccount = nextAccount;
                AllAccountList.Clear();
                for (int i = 0; i < App.AccountConfigManagerInstance.Configuration.AccountList.Count; i++)
                {
                    AllAccountList.Add(App.AccountConfigManagerInstance.Configuration.AccountList[i]);
                }

                // 删除原账号
                if (Directory.Exists(accountConfigFolder))
                {
                    Directory.Delete(accountConfigFolder, true);
                }

                App.AccountConfigManagerInstance.Configuration.AccountList.Remove(account);
                App.AccountConfigManagerInstance.Save();
                AllAccountList.Clear();
                for (int i = 0; i < App.AccountConfigManagerInstance.Configuration.AccountList.Count; i++)
                {
                    AllAccountList.Add(App.AccountConfigManagerInstance.Configuration.AccountList[i]);
                }
            }

            Restart();
        }

        [RelayCommand]
        private void RenameAccount()
        {
            Console.WriteLine("进入重命名环节");
            if (string.IsNullOrWhiteSpace(RenameAccountName)) return;
            if (App.AccountConfigManagerInstance!.Configuration.AccountList.Contains(RenameAccountName)) return;
            App.AccountConfigManagerInstance.Save();
            AccountConfigSave();
            Guid currentAccountGuid = AccountConfig.CalculateMd5(App.AccountConfigManagerInstance.Configuration.CurrentAccount);
            Guid newAccountGuid = AccountConfig.CalculateMd5(RenameAccountName);
            string sourceFolder = "Configs/" + currentAccountGuid;
            string destinationFolder = "Configs/" + newAccountGuid;
            Directory.Move(sourceFolder, destinationFolder);
            string privateAccountConfigFile = "Configs/" + newAccountGuid + "/PrivateAccountConfig.json";
            if (File.Exists(privateAccountConfigFile))
            {
                File.Delete(privateAccountConfigFile);
            }

            for (int i = 0; i < App.AccountConfigManagerInstance.Configuration.AccountList.Count; i++)
            {
                if (App.AccountConfigManagerInstance.Configuration.AccountList[i] == App.AccountConfigManagerInstance.Configuration.CurrentAccount)
                {
                    App.AccountConfigManagerInstance.Configuration.AccountList[i] = RenameAccountName;
                }
            }

            App.AccountConfigManagerInstance.UpdateCurrentAccount(RenameAccountName);
            AccountConfigCreate(newAccountGuid);
            CurrentAccount = RenameAccountName;
            AllAccountList.Clear();
            for (int i = 0; i < App.AccountConfigManagerInstance.Configuration.AccountList.Count; i++)
            {
                AllAccountList.Add(App.AccountConfigManagerInstance.Configuration.AccountList[i]);
            }

            AccountConfigLoad();
            Restart();
        }

        private void AccountConfigSave()
        {
            App.ThemeConfigManagerInstance!.Save();
            App.BackpackMaterialConfigManagerInstance!.Save();
            App.BackpackCharacterConfigManagerInstance!.Save();
            App.BackpackWeaponConfigManagerInstance!.Save();
            App.CalculatorPlanSettingConfigManagerInstance!.Save();
        }

        private void AccountConfigCreate(Guid guid)
        {
            App.ThemeConfigManagerInstance = new ThemeConfigManager(guid);
            App.BackpackMaterialConfigManagerInstance = new BackpackMaterialConfigManager(guid);
            App.BackpackCharacterConfigManagerInstance = new BackpackCharacterConfigManager(guid);
            App.BackpackWeaponConfigManagerInstance = new BackpackWeaponConfigManager(guid);
            App.CalculatorPlanSettingConfigManagerInstance = new CalculatorPlanSettingConfigManager(guid);
        }

        private void AccountConfigLoad()
        {
            App.ThemeConfigManagerInstance!.Load();
            App.BackpackMaterialConfigManagerInstance!.Load();
            App.BackpackCharacterConfigManagerInstance!.Load();
            App.BackpackWeaponConfigManagerInstance!.Load();
            App.CalculatorPlanSettingConfigManagerInstance!.Load();
        }

        private void Restart()
        {
            string? currentAppPath = Environment.ProcessPath;
            if (!string.IsNullOrEmpty(currentAppPath))
            {
                Process.Start(currentAppPath);
                Environment.Exit(0);
            }
        }

        public List<BaseUpdateInfoModel> InfoList { get; set; } =
        [
            new MileStoneUpdateInfoModel("26-04-13：V1.0.0发布。"), // todo 填入实际日期
        ];
    }
}