using CommunityToolkit.Mvvm.ComponentModel;
using Pathfinder.Classes;

namespace Pathfinder.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public Character character = 
            new(
                new Dictionary<AbilityScoreEnum, AbilityScore>()
                {
                    {AbilityScoreEnum.Strength, new AbilityScore(AbilityScoreEnum.Strength, 10, 0, 0) },
                    {AbilityScoreEnum.Dexterity, new AbilityScore(AbilityScoreEnum.Dexterity, 10, 0, 0) },
                    {AbilityScoreEnum.Constitution, new AbilityScore(AbilityScoreEnum.Constitution, 10, 0, 0) },
                    {AbilityScoreEnum.Wisdom, new AbilityScore(AbilityScoreEnum.Wisdom, 10, 0, 0) },
                    {AbilityScoreEnum.Intelligence, new AbilityScore(AbilityScoreEnum.Intelligence, 10, 0, 0) },
                    {AbilityScoreEnum.Charisma, new AbilityScore(AbilityScoreEnum.Charisma, 10, 0, 0) },
                },
            new(),new(),10);

        [ObservableProperty]
        public String text = "Hello World";
    }
}
