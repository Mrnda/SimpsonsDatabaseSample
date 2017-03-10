using System;
namespace SimpsonsDatabase.Models
{
	public class CharacterModel
	{
		public Guid Id { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public Gender Gender { get; set; }
		public string Description { get; set; }
	}
}
