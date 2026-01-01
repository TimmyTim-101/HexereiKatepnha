using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using HexereiKatepnha.Constants.EntityConstants;
using HexereiKatepnha.Models.EntityModels;
using HexereiKatepnha.Models.ModelsForViews.Database;
using HexereiKatepnha.Models.ModelsForViews.Database.SubModels;

namespace HexereiKatepnha.ViewModels.Database
{
    public class Database3ArtifactViewModel : ObservableObject
    {
        public ObservableCollection<Database3ArtifactModel> AllDatabase3ArtifactModelsList { get; } = new();

        public Database3ArtifactViewModel()
        {
            foreach (ArtifactSetModel e in AllEntities.AllArtifactSetEntities)
            {
                Database3ArtifactModel thisDatabase3ArtifactModels = new Database3ArtifactModel();
                thisDatabase3ArtifactModels.Vid = e.Vid;
                thisDatabase3ArtifactModels.Name = e.Name;
                for (int i = 1; i <= 5; i++)
                {
                    if (e.PositionNameDict.ContainsKey(i))
                    {
                        ArtifactTableRowModel thisRow = new ArtifactTableRowModel();
                        thisRow.ArtifactIconPath = SimpleConstants.ArtifactIconPath[i];
                        thisRow.Name = e.PositionNameDict[i];
                        for (int j = 1; j <= 5; j++)
                        {
                            if (e.RarityList.Contains(j))
                            {
                                ArtifactImageModel thisImage = new ArtifactImageModel();
                                thisImage.BackgroundPath = SimpleConstants.StarBackgroundImagePath[j];
                                thisImage.ImagePath = e.PositionImagePathDict[i];
                                thisRow.ImagePathList.Add(thisImage);
                            }
                        }

                        thisDatabase3ArtifactModels.ImageList.Add(thisRow);
                    }
                }

                for (int i = 1; i <= 4; i++)
                {
                    if (e.EffectDict.ContainsKey(i))
                    {
                        ArtifactEffectModel thisEffect = new ArtifactEffectModel();
                        thisEffect.Num = i;
                        thisEffect.Effect = e.EffectDict[i];
                        thisDatabase3ArtifactModels.EffectList.Add(thisEffect);
                    }
                }

                AllDatabase3ArtifactModelsList.Add(thisDatabase3ArtifactModels);
            }
        }
    }
}