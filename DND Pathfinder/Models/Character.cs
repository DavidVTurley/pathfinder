using System.Collections.ObjectModel;

namespace DND_Pathfinder.Models;

public partial class Character : BaseNotifyPropertyChanged
{
	private String _characterName;
    public String CharacterName {
		get => _characterName; 
		set
		{
			if(_characterName == value) return;
			_characterName = value;
			OnPropertyChanged();
		} 
	}

	public AbilityScoreManager AbilityScoreManager
	{
		get; init;
	}



    public Character(String name, AbilityScoreManager abilityManager)
    {
        CharacterName = name;
		AbilityScoreManager = abilityManager;
    }
}
