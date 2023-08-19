using System.Collections.ObjectModel;
using System.Collections.Specialized;

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
    public Boolean AddAbilityModifier(IEnumerable<AbilityAdjuster> modifiers)
    {
        Boolean result = true;
        foreach (AbilityAdjuster modifier in modifiers)
        {
            if (!AddAbilityModifier(modifier))
            {
                result = false;
            }
        }
        return result;
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

    public void AbilityAdjustment_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        if (e.Action == NotifyCollectionChangedAction.Add)
        {
            foreach (AbilityAdjuster item in e.NewItems)
            {
                AddAbilityModifier(item);
            }
        }
        else if (e.Action == NotifyCollectionChangedAction.Remove)
        {
            foreach (AbilityAdjuster item in e.OldItems)
            {
                RemoveAbilityModifier(item);
            }
        }
    }
}
