using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Database;

namespace HexereiKatepnha.ViewModels.Database
{
    public class Database4MaterialViewModel : ObservableObject
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
    }
}