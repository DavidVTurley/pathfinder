using CommunityToolkit.Mvvm.ComponentModel;

namespace Pathfinder.Classes;

public partial class AbilityScore : ObservableObject
{
    [ObservableProperty]
    public AbilityScoreEnum type;
    [ObservableProperty]
    public int score;
    [ObservableProperty]
    public int misc;
    [ObservableProperty]
    public int temp;

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
