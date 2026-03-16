using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Backpack;

namespace HexereiKatepnha.ViewModels.Backpack
{
    public partial class Backpack1CharacterViewModel : ObservableObject
    {
        [ObservableProperty] private int _elementFilter;
        [ObservableProperty] private int _weaponFilter;
        public ObservableCollection<Backpack1CharacterModel> AllCharacterList { get; } = new();
        [ObservableProperty] private Backpack1CharacterModel _selectedCharacter;
        public ICollectionView CharacterView { get; }
        public string Element1ImagePath { get; set; } = StringConstants.ElementTypeImagePath[Enumeration.ElementType.Pyro];
        public string Element2ImagePath { get; set; } = StringConstants.ElementTypeImagePath[Enumeration.ElementType.Hydro];
        public string Element3ImagePath { get; set; } = StringConstants.ElementTypeImagePath[Enumeration.ElementType.Anemo];
        public string Element4ImagePath { get; set; } = StringConstants.ElementTypeImagePath[Enumeration.ElementType.Electro];
        public string Element5ImagePath { get; set; } = StringConstants.ElementTypeImagePath[Enumeration.ElementType.Dendro];
        public string Element6ImagePath { get; set; } = StringConstants.ElementTypeImagePath[Enumeration.ElementType.Cryo];
        public string Element7ImagePath { get; set; } = StringConstants.ElementTypeImagePath[Enumeration.ElementType.Geo];
        public string Weapon1ImagePath { get; set; } = StringConstants.WeaponTypeImagePath[Enumeration.WeaponType.Sword];
        public string Weapon2ImagePath { get; set; } = StringConstants.WeaponTypeImagePath[Enumeration.WeaponType.Claymore];
        public string Weapon3ImagePath { get; set; } = StringConstants.WeaponTypeImagePath[Enumeration.WeaponType.Pole];
        public string Weapon4ImagePath { get; set; } = StringConstants.WeaponTypeImagePath[Enumeration.WeaponType.Catalyst];
        public string Weapon5ImagePath { get; set; } = StringConstants.WeaponTypeImagePath[Enumeration.WeaponType.Bow];

        public Backpack1CharacterViewModel()
        {
            foreach (CharacterModel e in AllEntities.AllCharacter)
            {
                Backpack1CharacterModel thisBackpack1CharacterModel = new Backpack1CharacterModel();
                thisBackpack1CharacterModel.ImagePath = e.ImagePath;
                thisBackpack1CharacterModel.ElementType = e.ElementType;
                thisBackpack1CharacterModel.ElementImagePath = StringConstants.ElementTypeImagePath[e.ElementType];
                thisBackpack1CharacterModel.BackgroundImagePath = StringConstants.StarBackgroundImagePath[e.Star];
                thisBackpack1CharacterModel.Name = e.Name;
                thisBackpack1CharacterModel.WeaponType = e.WeaponType;
                AllCharacterList.Add(thisBackpack1CharacterModel);
            }

            _selectedCharacter = AllCharacterList[0];
            CharacterView = CollectionViewSource.GetDefaultView(AllCharacterList);
            CharacterView.Filter = CharacterFilter;
        }

        private bool CharacterFilter(object item)
        {
            if (item is Backpack1CharacterModel c)
            {
                bool isElement = true;
                bool isWeapon = true;
                switch (ElementFilter)
                {
                    case 1: isElement = c.ElementType == Enumeration.ElementType.Pyro; break;
                    case 2: isElement = c.ElementType == Enumeration.ElementType.Hydro; break;
                    case 3: isElement = c.ElementType == Enumeration.ElementType.Anemo; break;
                    case 4: isElement = c.ElementType == Enumeration.ElementType.Electro; break;
                    case 5: isElement = c.ElementType == Enumeration.ElementType.Dendro; break;
                    case 6: isElement = c.ElementType == Enumeration.ElementType.Cryo; break;
                    case 7: isElement = c.ElementType == Enumeration.ElementType.Geo; break;
                }

                switch (WeaponFilter)
                {
                    case 1: isWeapon = c.WeaponType == Enumeration.WeaponType.Sword; break;
                    case 2: isWeapon = c.WeaponType == Enumeration.WeaponType.Claymore; break;
                    case 3: isWeapon = c.WeaponType == Enumeration.WeaponType.Pole; break;
                    case 4: isWeapon = c.WeaponType == Enumeration.WeaponType.Catalyst; break;
                    case 5: isWeapon = c.WeaponType == Enumeration.WeaponType.Bow; break;
                }

                return isElement && isWeapon;
            }

            return false;
        }

        private void UpdateSelection()
        {
            if (!CharacterView.Contains(SelectedCharacter))
            {
                SelectedCharacter = CharacterView.Cast<Backpack1CharacterModel>().FirstOrDefault()!;
            }
        }

        partial void OnElementFilterChanged(int value)
        {
            CharacterView.Refresh();
            UpdateSelection();
        }

        partial void OnWeaponFilterChanged(int value)
        {
            CharacterView.Refresh();
            UpdateSelection();
        }

        [RelayCommand]
        private void ClickOnElementFilter(String value)
        {
            int valueInt = Int32.Parse(value);
            if (valueInt == ElementFilter)
            {
                ElementFilter = 0;
            }
            else
            {
                ElementFilter = valueInt;
            }
        }

        [RelayCommand]
        private void ClickOnWeaponFilter(String value)
        {
            int valueInt = Int32.Parse(value);
            if (valueInt == WeaponFilter)
            {
                WeaponFilter = 0;
            }
            else
            {
                WeaponFilter = valueInt;
            }
        }
    }
}