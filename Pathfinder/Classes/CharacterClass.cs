using CommunityToolkit.Mvvm.ComponentModel;

namespace Pathfinder;

public partial class CharacterClass : ObservableObject
{
    [ObservableProperty]
    public String className;
    [ObservableProperty]
    public Int32 hitDice;
        
}

