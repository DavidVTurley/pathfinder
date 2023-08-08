namespace DND_Pathfinder.Models
{
	public partial class Character : ObservableObject
	{
		[ObservableProperty]
		private String _name;

		[ObservableProperty]
		private Int32 _age;

		[ObservableProperty]
		private Race _race;

		[ObservableProperty]
		private Dictionary<AbilityScore.AbilityScoreType, AbilityScore> _abilityScores;

		public Int32 Strength
		{
			get
			{
				return CalculateAdjustedAbilityScore(AbilityScore.AbilityScoreType.Strength);
			}
		}
		public Int32 Dexterity
		{
			get
			{
				return CalculateAdjustedAbilityScore(AbilityScore.AbilityScoreType.Dexterity);
			}
		}
		public Int32 Constitution
		{
			get
			{
				return CalculateAdjustedAbilityScore(AbilityScore.AbilityScoreType.Constitution);
			}
		}
		public Int32 Wisdom
		{
			get
			{
				return CalculateAdjustedAbilityScore(AbilityScore.AbilityScoreType.Wisdom);
			}
		}
		public Int32 Intelligence
		{
			get
			{
				return CalculateAdjustedAbilityScore(AbilityScore.AbilityScoreType.Intelligence);
			}
		}
		public Int32 Charisma
		{
			get
			{
				return CalculateAdjustedAbilityScore(AbilityScore.AbilityScoreType.Charisma);
			}
		}

		private Int32 CalculateAdjustedAbilityScore(AbilityScore.AbilityScoreType abilityScoreType)
		{
			Int32 total = 0;
			total += AbilityScores[abilityScoreType].Score;
			IEnumerable<(AbilityScore.AbilityScoreType AbilitieType, int adjustment)> sortedRacialAbilities = Race.RacialAbilityModifiers.Where(x => x.AbilitieType == abilityScoreType);
			total += sortedRacialAbilities.Sum(x => x.adjustment);
			return total;
		}

		public Character(String name, int age, List<AbilityScore> abilityScores, Race race)
		{
			Name = name;
			Age = age;
			Race = race;
			
			var tempAbilityScores = new Dictionary<AbilityScore.AbilityScoreType, AbilityScore>();
			foreach (AbilityScore ability in abilityScores)
			{
				tempAbilityScores.Add(ability.Type, ability);
			}

			AbilityScores = tempAbilityScores;
		}

		public static Character GetTestCharacterSheet(String name = "Steve",
			Int32 age = 21, List<AbilityScore> abilityScores = null)
		{
			abilityScores ??= AbilityScore.GetBaseAbilityScoreSheet();

			Character character = new Character(
				name,
				age,
				new List<AbilityScore>(abilityScores),
				new Race(
					"Testing Race",
					new() {
						(AbilityScore.AbilityScoreType.Strength, -2),
						(AbilityScore.AbilityScoreType.Dexterity, -1),
						(AbilityScore.AbilityScoreType.Constitution, 0),
						(AbilityScore.AbilityScoreType.Wisdom, 1),
						(AbilityScore.AbilityScoreType.Intelligence, 2),
						(AbilityScore.AbilityScoreType.Charisma, 3),}
					));

			return character;
		}


		public static Character GetBaseCharacterSheet(String name = "Steve", 
			Int32 age = 21, List<AbilityScore> abilityScores = null)
		{
			abilityScores ??= AbilityScore.GetBaseAbilityScoreSheet();

			Character character = new Character(
				name, 
				age, 
				new List<AbilityScore>(abilityScores),
				new Race("Human")
				);

			return character;
		}

		public static List<AbilityScore> GetBaseAbilityScoreSheet() => AbilityScore.GetBaseAbilityScoreSheet();
	}
}
