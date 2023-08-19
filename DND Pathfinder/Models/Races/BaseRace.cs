namespace DND_Pathfinder.Models.Races;
public class BaseRace : BaseNotifyPropertyChanged, IRace
{
    private string _name;
    private string _type;
    private string _subType;
    private ObservableCollection<AbilityAdjuster> _abilityAdjustment;

    public string Name
    {
        get => _name;
        set
        {
            if (_name == value) return;
            _name = value;
            OnPropertyChanged();
        }
    }
    public string Type
    {
        get => _type;
        set
        {
            if (_type == value) return;
            _type = value;
            OnPropertyChanged();
        }
    }
    public string SubType
    {
        get => _subType;
        set
        {
            if (_subType == value) return;
            _subType = value;
            OnPropertyChanged();
        }
    }
    public ObservableCollection<AbilityAdjuster> AbilityAdjustment
    {
        get => _abilityAdjustment;
        set
        {
            if (_abilityAdjustment == value) return;
            _abilityAdjustment = value;
            OnPropertyChanged();
        }
    }

    public BaseRace(string name, string type, string subType, IEnumerable<AbilityAdjuster> extraRacialAbilityAdjuster)
    {
        Name = name;
        Type = type;
        SubType = subType;
        AbilityAdjustment = new ObservableCollection<AbilityAdjuster>(extraRacialAbilityAdjuster);
    }



}
