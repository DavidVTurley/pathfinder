namespace Pathfinder.Models;

public partial class Character : ObservableObject
{
    [ObservableProperty]
    public String name;

    // public Dictionary<AbilityScoreEnum, AbilityScoreType> AbilityScores = new();
    [ObservableProperty]
    private ObservableCollection<AbilityScore> _abilityScores = new();

    [ObservableProperty]
    private Int32 _hitpoints;

    [ObservableProperty]
	private Race _race;
    [ObservableProperty]
	private SkillManager _skills;
    [ObservableProperty]
	private CharacterClass _characterClass;
    // Race
    //   Ability Mods
    //   Traits
    // Class
    //   Hit Dice
    // Feats
    // 

    // Todo Optimize so it is using a dict or hashset
    public Character(String name, IEnumerable<AbilityScore> abilityScores, Race race, SkillManager skills, int hitpoints)
    {
        Name = name;

        // Hate that this seems to be one of the most efficient ways : /
        foreach (AbilityScore ability in abilityScores)
        {
            AbilityScores.Add(ability);
        };

		Race = race;
        Skills = skills;
        Hitpoints = hitpoints;
    }
}
