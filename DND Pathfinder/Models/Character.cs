using DND_Pathfinder.Models.Races;
using System.Collections.ObjectModel;

namespace DND_Pathfinder.Models;

public partial class Character : BaseNotifyPropertyChanged
{
	private String _characterName;
	private Int32 _speed;
    private Int32 _age;
    private Int32 _height;
    private IRace _race;

    public ObservableCollection<String> Languages { get; set; }
    public String CharacterName {
		get => _characterName; 
		set
		{
			if(_characterName == value) return;
			_characterName = value;
			OnPropertyChanged();
		} 
	}
    public Int32 Speed
    {
        get => _speed;
        set
        {
            if (_speed == value) return;
            _speed = value;
            OnPropertyChanged();
        }
    }
    public Int32 Age
    {
        get => _age;
        set
        {
            if (_age == value) return;
            _age = value;
            OnPropertyChanged();
        }
    }
    public Int32 Height
    {
        get => _height;
        set
        {
            if (_height == value) return;
            _height = value;
            OnPropertyChanged();
        }
    }

    public IRace Race
    {
        get => _race;
        set
        {
            if(_race == value) return;
            _race = value;
            OnPropertyChanged();
        }
    }

	public AbilityScoreManager AbilityScoreManager
	{
		get; init;
	}

   

    public Character(String name, AbilityScoreManager abilityManager, IRace race)
    {
        CharacterName = name;
		AbilityScoreManager = abilityManager;
        Race = race;
        AbilityScoreManager.AddAbilityModifier(Race.AbilityAdjustment);

        Race.AbilityAdjustment.CollectionChanged += AbilityScoreManager.AbilityAdjustment_CollectionChanged;

    }


}
