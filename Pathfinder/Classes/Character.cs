using CommunityToolkit.Mvvm.ComponentModel;
using Pathfinder.Classes;

namespace Pathfinder;

public partial class Character : ObservableObject
{
    [ObservableProperty]
    public String name;

    public Dictionary<AbilityScoreEnum, AbilityScore> AbilityScores = new();

    [ObservableProperty]
    public Int32 hitpoints;

    [ObservableProperty]
    public Race race;
    [ObservableProperty]
    public SkillManager skills;
    [ObservableProperty]
    public CharacterClass characterClass;
    // Race
    //   Ability Mods
    //   Traits
    // Class
    //   Hit Dice
    // Feats
    // 
    public Character(IDictionary<AbilityScoreEnum, AbilityScore> abilityScores, Race race, SkillManager skills, int hitpoints)
    {
		foreach (KeyValuePair<AbilityScoreEnum, AbilityScore> score in abilityScores)
        {
            AbilityScores.Add(score.Key, score.Value);
		}

        Race = race;
        Skills = skills;
        Hitpoints = hitpoints;
    }
}
