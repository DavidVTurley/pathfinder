using System.Collections.ObjectModel;

namespace DND_Pathfinder.Models.AbilityScores;

public class AbilityScoreManager
{
    public ObservableCollection<AbilityScore> AbilityScores { get; }

    public AbilityScoreManager(IEnumerable<AbilityScore> abilityScores, IEnumerable<AbilityModifier> modifiers = null)
    {
        AbilityScores = new ObservableCollection<AbilityScore>(abilityScores);
        
        if (modifiers != null)
        {
            foreach (AbilityModifier modifier in modifiers)
            {
                AddAbilityModifier(modifier);
            }
        }
    }

    public Boolean AddAbilityModifier(AbilityModifier modifier)
    {
        AbilityScore score = GetAbilityScoreFromAbilityType(modifier.Type);
        if(score == null) 
            return false; 

        return score.AddAbilityModifier(modifier);
    }

    public Boolean RemoveAbilityModifier(AbilityModifier modifier)
    {
        AbilityScore score = GetAbilityScoreFromAbilityType(modifier.Type);
        if (score == null)
            return false;

        return score.RemoveAbilityModifier(modifier);

    }

    private AbilityScore GetAbilityScoreFromAbilityType(AbilityType type)
    {
        return AbilityScores.First(x => x.AbilityType == type);
    }
}
