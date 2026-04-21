using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Database;

namespace HexereiKatepnha.ViewModels.Database
{
    public partial class Database4MaterialViewModel : ObservableObject
    {
        public ObservableCollection<Database4MaterialModel> AllMaterialList { get; set; } = [];

        public Database4MaterialViewModel()
        {
            foreach (List<MaterialModel> l in AllEntities.AllMaterialLists)
            {
                foreach (MaterialModel e in l)
                {
                    Database4MaterialModel thisModel = new Database4MaterialModel
                    {
                        Vid = e.Vid,
                        Name = e.Name,
                        ImagePath = e.ImagePath,
                        BackgroundImagePath = StringConstants.StarBackgroundImagePath[e.Star],
                        StarImagePath = StringConstants.StarImagePath[e.Star]
                    };
                    AllMaterialList.Add(thisModel);
                }
            }
        }

        [RelayCommand]
        public void OpenHelpWebPage()
        {
            string url = "https://github.com/TimmyTim-101/HexereiKatepnha/wiki/%E6%95%B0%E6%8D%AE%E5%BA%93%E2%80%90-%E6%9D%90%E6%96%99";
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
    }
}