namespace DND_Pathfinder.Models.AbilityScores;

public struct AbilityAdjuster
{
    public AbilityType Type { get; init; }
    public String ModifierName { get; init; }
    public Int32 StatAdjustment { get; init; }

    public AbilityAdjuster(AbilityType type, string modifierName, int statAdjustment)
    {
        Type = type;
        ModifierName = modifierName;
        StatAdjustment = statAdjustment;
    }
}
