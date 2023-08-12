using System.Collections.ObjectModel;

namespace DND_Pathfinder.Models.AbilityScores;
public class AbilityScore : BaseNotifyPropertyChanged
{
    private Int32 _baseScore;
    private Int32 _tempScore;

    private ObservableCollection<AbilityAdjuster> _abilityAdjustments;


	public AbilityType AbilityType {get;}

    public Int32 TotalScore
    {
        get
        {
            Int32 score = BaseScore + TempScore;

            foreach (AbilityAdjuster modifier in _abilityAdjustments)
            {
                score += modifier.StatAdjustment;
            }
            return score;
        }
    }
    public Int32 Modifier
    {
        get
        {
            Decimal score = TotalScore;

            score -= 10;

            return (int)Math.Floor(score / 2);
        }
    }
    private void TotalScoreNeedsToChange()
    {
        OnPropertyChanged(nameof(TotalScore));
        OnPropertyChanged(nameof(Modifier));
    }


    public Int32 BaseScore
	{
		get { return _baseScore; }
		set
		{
			if (_baseScore == value) return;
			_baseScore = value;
			OnPropertyChanged();
            TotalScoreNeedsToChange();
        }
    }
	public Int32 TempScore
	{
		get { return _tempScore; }
		set
		{
			if (_tempScore == value) return;
			_tempScore = value;
			OnPropertyChanged();
            TotalScoreNeedsToChange();
        }
    }

    public AbilityScore(AbilityType abilityType, int baseScore = 10, int tempScore = 0, IEnumerable<AbilityAdjuster> abilityAdjustments = null)
    {
        _abilityAdjustments = _abilityAdjustments == null
            ? new ObservableCollection<AbilityAdjuster>()
            : new ObservableCollection<AbilityAdjuster>(abilityAdjustments);

        AbilityType = abilityType;
        BaseScore = baseScore;
        TempScore = tempScore;
    }

	public Boolean AddAbilityModifier(AbilityAdjuster modifier)
	{
		if(modifier.Type != AbilityType) throw new Exception("The ability score type is not correct");

        Boolean containsModifier = _abilityAdjustments.Contains(modifier);
        if (containsModifier) throw new Exception("The ability score modifier already exists");


        _abilityAdjustments.Add(modifier);
        TotalScoreNeedsToChange();
        return true;
    }
	public Boolean RemoveAbilityModifier(AbilityAdjuster modifier)
	{
        if (!_abilityAdjustments.Remove(modifier)) return false;

        TotalScoreNeedsToChange();
        return true;
	}
	public Boolean RemoveAbilityModifier(String nameOfModifier)
	{
        AbilityAdjuster foundAbility = _abilityAdjustments.First(x => x.ModifierName == nameOfModifier);

		return RemoveAbilityModifier(foundAbility);
    }

}
