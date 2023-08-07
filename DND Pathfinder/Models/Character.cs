namespace DND_Pathfinder.Models
{
	public partial class Character : ObservableObject
	{
		[ObservableProperty]
		private String _name;

		[ObservableProperty]
		private Int32 _age;

		[ObservableProperty]
		private ObservableCollection<AbilityScore> _abilities;

		public Character(String name, int age, ObservableCollection<AbilityScore> abilities)
		[ObservableProperty]
		private Dictionary<AbilityScore.AbilityScoreTypeEnum, AbilityScore> _abilities;

		{
			Name = name;
			Age = age;
			_abilities = abilities;
			var temp = new Dictionary<AbilityScore.AbilityScoreTypeEnum, AbilityScore>();
			foreach (AbilityScore ability in abilityScores)
			{
				temp.Add(ability.Type, ability);
			}

			Abilities = temp;
		}

		public static Character GetBaseCharacterSheet(String name = "Steve", 
			Int32 age = 21, 
			List<AbilityScore> abilityScores = null)
		{
			abilityScores ??= AbilityScore.GetBaseAbilityScoreSheet();

			Character character = new Character(
				name, 
				age, 
				new List<AbilityScore>(abilityScores),
				);

			return character;
		}

		public static List<AbilityScore> GetBaseAbilityScoreSheet() => AbilityScore.GetBaseAbilityScoreSheet();
	}
}
