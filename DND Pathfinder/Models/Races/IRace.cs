namespace DND_Pathfinder.Models.Races;
public interface IRace 
{
    public String Name { get; set; }
    public String Type { get; set; }
    public String SubType { get; set; }
    public ObservableCollection<AbilityAdjuster> AbilityAdjustment { get; set; }

}
