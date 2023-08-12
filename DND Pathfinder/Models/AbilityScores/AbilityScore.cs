using System.Collections.ObjectModel;

namespace DND_Pathfinder.Models.AbilityScores;
public class AbilityScore : BaseNotifyPropertyChanged
{
    private Int32 _baseScore;
    private Int32 _tempScore;

    private ObservableCollection<AbilityModifier> _abilityModifiers;


	public AbilityType AbilityType {get;}
	
	public Int32 TotalScore
	{
		get
		{
			Int32 score = BaseScore + TempScore;

			foreach (AbilityModifier modifier in _abilityModifiers)
			{
				score += modifier.StatAdjustment;
			}

            return score;
		}
	}

	public Int32 BaseScore
	{
		get { return _baseScore; }
		set
		{
			if (_baseScore == value) return;
			_baseScore = value;
			OnPropertyChanged();
			OnPropertyChanged(nameof(TotalScore));
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
            OnPropertyChanged(nameof(TotalScore));
        }
    }

    public AbilityScore(AbilityType abilityType, int baseScore = 10, int tempScore = 0, IEnumerable<AbilityModifier> abilityAdjustments = null)
    {
        _abilityModifiers = _abilityModifiers == null
            ? new ObservableCollection<AbilityModifier>()
            : new ObservableCollection<AbilityModifier>(abilityAdjustments);

        AbilityType = abilityType;
        BaseScore = baseScore;
        TempScore = tempScore;
    }

	public Boolean AddAbilityModifier(AbilityModifier modifier)
	{
		if(modifier.Type != AbilityType) throw new Exception("The ability score type is not correct");

        Boolean containsModifier = _abilityModifiers.Contains(modifier);
        if (containsModifier) throw new Exception("The ability score modifier already exists");


        _abilityModifiers.Add(modifier);
		OnPropertyChanged(nameof(TotalScore));
		return true;
    }
	public Boolean RemoveAbilityModifier(AbilityModifier modifier)
	{
        if (!_abilityModifiers.Remove(modifier)) return false;

        OnPropertyChanged(nameof(TotalScore));
        return true;
	}
	public Boolean RemoveAbilityModifier(String nameOfModifier)
	{
        AbilityModifier foundAbility = _abilityModifiers.First(x => x.ModifierName == nameOfModifier);

		return RemoveAbilityModifier(foundAbility);
    }
}
