using CommunityToolkit.Mvvm.ComponentModel;

namespace Pathfinder;

public partial class Race : ObservableObject
{
    [ObservableProperty]
    public Dictionary<String, Int32> raceAbilityModifiers = new();
    [ObservableProperty]
    public Dictionary<String, Int32> raceSkillModifiers = new();

    public Race() { }
    public Race(Dictionary<string, int> raceSkillModifiers, Dictionary<string, int> raceAbilityModifiers)
    {
        RaceSkillModifiers = raceSkillModifiers;
        RaceAbilityModifiers = raceAbilityModifiers;
    }
}

