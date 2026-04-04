using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Constants.EntityConstants.GeneralConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Database;

namespace HexereiKatepnha.ViewModels.Database
{
    public class Database3ArtifactViewModel : ObservableObject
    {
        public ObservableCollection<Database3ArtifactModel> AllDatabase3ArtifactModelsList { get; } = new();

        public Database3ArtifactViewModel()
        {
            foreach (ArtifactSetModel e in AllEntities.AllArtifactSetEntities)
            {
                Database3ArtifactModel thisDatabase3ArtifactModels = new Database3ArtifactModel
                {
                    Vid = e.Vid,
                    Name = e.Name
                };
                for (int i = 1; i <= 5; i++)
                {
                    Database3ArtifactPositionModel thisPosition = new Database3ArtifactPositionModel();
                    if (e.PositionNameDict.TryGetValue(i, out var thisName))
                    {
                        thisPosition.PositionIconPath = StringConstants.ArtifactIconPath[i];
                        thisPosition.PositionName = thisName;
                        for (int j = 1; j <= 5; j++)
                        {
                            if (e.RarityList.Contains(j))
                            {
                                Database3ArtifactRarityModel thisRarityModel = new Database3ArtifactRarityModel
                                {
                                    BackgroundImagePath = StringConstants.StarBackgroundImagePath[j],
                                    ImagePath = e.PositionImagePathDict[i]
                                };
                                thisPosition.PositionRarityList.Add(thisRarityModel);
                            }
                        }
                    }

                    thisDatabase3ArtifactModels.PositionList.Add(thisPosition);
                }

                for (int i = 1; i <= 4; i++)
                {
                    if (e.EffectDict.TryGetValue(i, out var thisEffectString))
                    {
                        Database3ArtifactEffectModel thisEffect = new Database3ArtifactEffectModel
                        {
                            Num = i,
                            Effect = thisEffectString
                        };
                        thisDatabase3ArtifactModels.EffectList.Add(thisEffect);
                    }
                }

                AllDatabase3ArtifactModelsList.Add(thisDatabase3ArtifactModels);
            }
        }
    }
}