namespace Pathfinder.Models;

public partial class Race : ObservableObject
{
    [ObservableProperty]
    private Dictionary<String, Int32> _raceAbilityModifiers = new();
    [ObservableProperty]
	private Dictionary<String, Int32> _raceSkillModifiers = new();

    public Race() { }
    public Race(Dictionary<string, int> raceSkillModifiers, Dictionary<string, int> raceAbilityModifiers)
    {
        RaceSkillModifiers = raceSkillModifiers;
        RaceAbilityModifiers = raceAbilityModifiers;
    }
}

