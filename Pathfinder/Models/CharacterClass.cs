namespace Pathfinder.Models;

public partial class CharacterClass : ObservableObject
{
    [ObservableProperty]
	private String _className;
    [ObservableProperty]
	private Int32 _hitDice;
        
}

