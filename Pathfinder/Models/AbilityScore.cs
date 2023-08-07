namespace Pathfinder.Models;

public partial class AbilityScore : ObservableObject
{
    [ObservableProperty]
	private AbilityScoreEnum _type;
    [ObservableProperty]
	private int _score;
    [ObservableProperty]
	private int _misc;
    [ObservableProperty]
	private int _temp;

    public AbilityScore(AbilityScoreEnum type, int score, int misc, int temp)
    {
        Type = type;
        Score = score;
        Misc = misc;
        Temp = temp;
    }

    public Int32 GetScore()
    {
        return Score+Misc+Temp;
    }
}
public enum AbilityScoreEnum
{
	Strength,
	Dexterity,
	Constitution,
	Wisdom,
	Intelligence,
	Charisma,
}


