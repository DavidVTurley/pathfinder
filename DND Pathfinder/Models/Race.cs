namespace DND_Pathfinder.Models
{
	public partial class Race : ObservableObject
	{
		[ObservableProperty]
		private String _name;
		[ObservableProperty]
		private List<(AbilityScore.AbilityScoreType AbilitieType, Int32 adjustment)> _racialAbilityModifiers;

		public Race(string name, List<(AbilityScore.AbilityScoreType AbilitieType, Int32 racialAdjustment)> racialAbilityModifiers = null)
		{
			Name = name;
			RacialAbilityModifiers = 
				racialAbilityModifiers ?? 
				new List<(AbilityScore.AbilityScoreType AbilitieType, int adjustment)>();
		}
	}
}
