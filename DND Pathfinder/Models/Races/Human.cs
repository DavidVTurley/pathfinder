
namespace DND_Pathfinder.Models.Races;
public class Human : BaseRace
{
    public Human(string name, string type, string subType, AbilityType racialBonusChoice, IEnumerable<AbilityAdjuster> extraRacialAbilityAdjuster) : base(name, type, subType, extraRacialAbilityAdjuster)
    {
        AbilityAdjustment.Add(new AbilityAdjuster(racialBonusChoice, "Human Racial Ability Score Adjustment", 2));
    }
}
