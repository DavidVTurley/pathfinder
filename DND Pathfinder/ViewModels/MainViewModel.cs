namespace DND_Pathfinder.ViewModels
{
	public partial class MainViewModel: ObservableObject
	{
		[ObservableProperty]
		private Character _character;


		public MainViewModel(Character character = null)
		{
			_character = character == null ? Character.GetBaseCharacterSheet() : character;
		}
	}
}
