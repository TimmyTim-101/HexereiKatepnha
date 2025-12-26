using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Database;

namespace HexereiKatepnha.ViewModels.Database
{
    public partial class Database4MaterialViewModel : ObservableObject
    {
        [ObservableProperty] private ObservableCollection<Database4MaterialModel> _list1 = new();
        [ObservableProperty] private ObservableCollection<Database4MaterialModel> _list2 = new();
        [ObservableProperty] private ObservableCollection<Database4MaterialModel> _list3 = new();
        [ObservableProperty] private ObservableCollection<Database4MaterialModel> _list4 = new();
        [ObservableProperty] private ObservableCollection<Database4MaterialModel> _list5 = new();
        [ObservableProperty] private ObservableCollection<Database4MaterialModel> _list6 = new();
        [ObservableProperty] private ObservableCollection<Database4MaterialModel> _list7 = new();

        public Database4MaterialViewModel()
        {
            foreach (MaterialModel e in AllEntities.AllMaterialMora)
            {
                Database4MaterialModel thisModel = new Database4MaterialModel();
                thisModel.Vid = e.Vid;
                thisModel.Name = e.Name;
                thisModel.ImagePath = e.ImagePath;
                thisModel.BackgroundImagePath = Constants.EntityConstants.Constants.StarBackgroundImagePath[e.Star];
                thisModel.StarImagePath = Constants.EntityConstants.Constants.StarImagePath[e.Star];
                List1.Add(thisModel);
            }

            foreach (MaterialModel e in AllEntities.AllMaterialCharacterExp)
            {
                Database4MaterialModel thisModel = new Database4MaterialModel();
                thisModel.Vid = e.Vid;
                thisModel.Name = e.Name;
                thisModel.ImagePath = e.ImagePath;
                thisModel.BackgroundImagePath = Constants.EntityConstants.Constants.StarBackgroundImagePath[e.Star];
                thisModel.StarImagePath = Constants.EntityConstants.Constants.StarImagePath[e.Star];
                List1.Add(thisModel);
            }

            foreach (MaterialModel e in AllEntities.AllMaterialWeaponExp)
            {
                Database4MaterialModel thisModel = new Database4MaterialModel();
                thisModel.Vid = e.Vid;
                thisModel.Name = e.Name;
                thisModel.ImagePath = e.ImagePath;
                thisModel.BackgroundImagePath = Constants.EntityConstants.Constants.StarBackgroundImagePath[e.Star];
                thisModel.StarImagePath = Constants.EntityConstants.Constants.StarImagePath[e.Star];
                List1.Add(thisModel);
            }

            foreach (MaterialModel e in AllEntities.AllMaterialCharacterWeaponEnhancement1)
            {
                Database4MaterialModel thisModel = new Database4MaterialModel();
                thisModel.Vid = e.Vid;
                thisModel.Name = e.Name;
                thisModel.ImagePath = e.ImagePath;
                thisModel.BackgroundImagePath = Constants.EntityConstants.Constants.StarBackgroundImagePath[e.Star];
                thisModel.StarImagePath = Constants.EntityConstants.Constants.StarImagePath[e.Star];
                List2.Add(thisModel);
            }

            foreach (MaterialModel e in AllEntities.AllMaterialCharacterWeaponEnhancement2)
            {
                Database4MaterialModel thisModel = new Database4MaterialModel();
                thisModel.Vid = e.Vid;
                thisModel.Name = e.Name;
                thisModel.ImagePath = e.ImagePath;
                thisModel.BackgroundImagePath = Constants.EntityConstants.Constants.StarBackgroundImagePath[e.Star];
                thisModel.StarImagePath = Constants.EntityConstants.Constants.StarImagePath[e.Star];
                List2.Add(thisModel);
            }

            foreach (MaterialModel e in AllEntities.AllMaterialCharacterLevelUp1)
            {
                Database4MaterialModel thisModel = new Database4MaterialModel();
                thisModel.Vid = e.Vid;
                thisModel.Name = e.Name;
                thisModel.ImagePath = e.ImagePath;
                thisModel.BackgroundImagePath = Constants.EntityConstants.Constants.StarBackgroundImagePath[e.Star];
                thisModel.StarImagePath = Constants.EntityConstants.Constants.StarImagePath[e.Star];
                List3.Add(thisModel);
            }

            foreach (MaterialModel e in AllEntities.AllMaterialCharacterLevelUp2)
            {
                Database4MaterialModel thisModel = new Database4MaterialModel();
                thisModel.Vid = e.Vid;
                thisModel.Name = e.Name;
                thisModel.ImagePath = e.ImagePath;
                thisModel.BackgroundImagePath = Constants.EntityConstants.Constants.StarBackgroundImagePath[e.Star];
                thisModel.StarImagePath = Constants.EntityConstants.Constants.StarImagePath[e.Star];
                List3.Add(thisModel);
            }

            foreach (MaterialModel e in AllEntities.AllMaterialCharacterAscension)
            {
                Database4MaterialModel thisModel = new Database4MaterialModel();
                thisModel.Vid = e.Vid;
                thisModel.Name = e.Name;
                thisModel.ImagePath = e.ImagePath;
                thisModel.BackgroundImagePath = Constants.EntityConstants.Constants.StarBackgroundImagePath[e.Star];
                thisModel.StarImagePath = Constants.EntityConstants.Constants.StarImagePath[e.Star];
                List4.Add(thisModel);
            }

            foreach (MaterialModel e in AllEntities.AllMaterialCharacterTalent)
            {
                Database4MaterialModel thisModel = new Database4MaterialModel();
                thisModel.Vid = e.Vid;
                thisModel.Name = e.Name;
                thisModel.ImagePath = e.ImagePath;
                thisModel.BackgroundImagePath = Constants.EntityConstants.Constants.StarBackgroundImagePath[e.Star];
                thisModel.StarImagePath = Constants.EntityConstants.Constants.StarImagePath[e.Star];
                List5.Add(thisModel);
            }

            foreach (MaterialModel e in AllEntities.AllMaterialWeaponAscension)
            {
                Database4MaterialModel thisModel = new Database4MaterialModel();
                thisModel.Vid = e.Vid;
                thisModel.Name = e.Name;
                thisModel.ImagePath = e.ImagePath;
                thisModel.BackgroundImagePath = Constants.EntityConstants.Constants.StarBackgroundImagePath[e.Star];
                thisModel.StarImagePath = Constants.EntityConstants.Constants.StarImagePath[e.Star];
                List6.Add(thisModel);
            }

            foreach (MaterialModel e in AllEntities.AllMaterialLocalSpecialty)
            {
                Database4MaterialModel thisModel = new Database4MaterialModel();
                thisModel.Vid = e.Vid;
                thisModel.Name = e.Name;
                thisModel.ImagePath = e.ImagePath;
                thisModel.BackgroundImagePath = Constants.EntityConstants.Constants.StarBackgroundImagePath[e.Star];
                thisModel.StarImagePath = Constants.EntityConstants.Constants.StarImagePath[e.Star];
                List7.Add(thisModel);
            }
        }
    }
}