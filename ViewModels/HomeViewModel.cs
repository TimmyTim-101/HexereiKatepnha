using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.ConfigModels;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.Messages;
using HexereiKatepnha.Models.ModelsForViews.Database.SubModels;
using HexereiKatepnha.Services;

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

        public HomeViewModel()
        {
            LocalCurrentTime = DateTime.Now.ToString("HH:mm:ss");
            ServerCurrentTime = DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(8)).ToString("HH:mm:ss");
            Birthday = DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(8)).Month * 100 + DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(8)).Day;
            IsServerTimeSame = LocalCurrentTime == ServerCurrentTime;
            IsServerTimeDifferent = !IsServerTimeSame;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (_, _) =>
            {
                LocalCurrentTime = DateTime.Now.ToString("HH:mm:ss");
                ServerCurrentTime = DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(8)).ToString("HH:mm:ss");
                Birthday = DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(8)).Month * 100 + DateTimeOffset.UtcNow.ToOffset(TimeSpan.FromHours(8)).Day;
                IsServerTimeSame = LocalCurrentTime == ServerCurrentTime;
                IsServerTimeDifferent = !IsServerTimeSame;
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
            while (BirthdayList.Count < 5)
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
                            if (currentYear % 4 == 0 && currentYear % 100 != 0)
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
            App.ThemeConfigManagerInstance!.Save();
            App.PrivateAccountConfigManagerInstance!.Save();
            // 切换账号
            App.AccountConfigManagerInstance.Configuration.CurrentAccount = account;
            App.AccountConfigManagerInstance.Save();
            Guid currentAccountGuid = AccountConfig.CalculateMd5(account);
            App.ThemeConfigManagerInstance = new ThemeConfigManager(currentAccountGuid);
            App.PrivateAccountConfigManagerInstance = new PrivateAccountConfigManager(currentAccountGuid);
            // 重新加载配置
            App.ThemeConfigManagerInstance.Load();
            App.PrivateAccountConfigManagerInstance.Load();
            // 更新本地变量
            CurrentAccount = account;
            AllAccountList.Clear();
            for (int i = 0; i < App.AccountConfigManagerInstance.Configuration.AccountList.Count; i++)
            {
                AllAccountList.Add(App.AccountConfigManagerInstance.Configuration.AccountList[i]);
            }

            WeakReferenceMessenger.Default.Send(new CurrentAccountChangesMessage(account));
        }

        [RelayCommand]
        private void DeleteAccount(string account)
        {
            // 删除前保存
            App.AccountConfigManagerInstance!.Save();
            App.ThemeConfigManagerInstance!.Save();
            App.PrivateAccountConfigManagerInstance!.Save();
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

                App.ThemeConfigManagerInstance = new ThemeConfigManager(accountGuid);
                App.PrivateAccountConfigManagerInstance = new PrivateAccountConfigManager(accountGuid);
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

                SwitchAccount(nextAccount);
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
        }

        [RelayCommand]
        private void RenameAccount()
        {
            Console.WriteLine("进入重命名环节");
            if (string.IsNullOrWhiteSpace(RenameAccountName)) return;
            if (App.AccountConfigManagerInstance!.Configuration.AccountList.Contains(RenameAccountName)) return;
            App.AccountConfigManagerInstance.Save();
            App.ThemeConfigManagerInstance!.Save();
            App.PrivateAccountConfigManagerInstance!.Save();
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

            App.AccountConfigManagerInstance.Configuration.CurrentAccount = RenameAccountName;

            App.AccountConfigManagerInstance.Save();
            App.ThemeConfigManagerInstance = new ThemeConfigManager(newAccountGuid);
            App.PrivateAccountConfigManagerInstance = new PrivateAccountConfigManager(newAccountGuid);
            CurrentAccount = RenameAccountName;
            WeakReferenceMessenger.Default.Send(new CurrentAccountChangesMessage(RenameAccountName));
            AllAccountList.Clear();
            for (int i = 0; i < App.AccountConfigManagerInstance.Configuration.AccountList.Count; i++)
            {
                AllAccountList.Add(App.AccountConfigManagerInstance.Configuration.AccountList[i]);
            }

            App.ThemeConfigManagerInstance.Load();
            App.PrivateAccountConfigManagerInstance.Load();
        }
    }
}