using System.Collections.ObjectModel;

namespace DND_Pathfinder.Models.AbilityScores;

public class AbilityScoreManager
{
    public ObservableCollection<AbilityScore> AbilityScores { get; }

    public AbilityScoreManager(IEnumerable<AbilityScore> abilityScores, IEnumerable<AbilityAdjuster> modifiers = null)
    {
        AbilityScores = new ObservableCollection<AbilityScore>(abilityScores);
        
        if (modifiers != null)
        {
            foreach (AbilityAdjuster modifier in modifiers)
            {
                AddAbilityModifier(modifier);
            }
        }
    }

    public Boolean AddAbilityModifier(AbilityAdjuster modifier)
    {
        AbilityScore score = GetAbilityScoreFromAbilityType(modifier.Type);
        if(score == null) 
            return false; 

        return score.AddAbilityModifier(modifier);
    }

    public Boolean RemoveAbilityModifier(AbilityAdjuster modifier)
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
