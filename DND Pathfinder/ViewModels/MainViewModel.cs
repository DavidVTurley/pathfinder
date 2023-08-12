namespace DND_Pathfinder.ViewModels;

public partial class MainViewModel : BaseNotifyPropertyChanged
	{
		public Character Character {
			get;
			init;
		}


		public MainViewModel(Character character = null)
		{
			Character = character ?? new Character("Steve",
				new AbilityScoreManager(
					new ObservableCollection<AbilityScore>() {
							new AbilityScore(AbilityType.Strength),
							new AbilityScore(AbilityType.Dexterity),
							new AbilityScore(AbilityType.Constitution),
							new AbilityScore(AbilityType.Wisdom),
							new AbilityScore(AbilityType.Intelligence),
							new AbilityScore(AbilityType.Charisma),
					}));




		}
	}
