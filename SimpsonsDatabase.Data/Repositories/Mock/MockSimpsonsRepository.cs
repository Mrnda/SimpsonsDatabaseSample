using System;
using System.Collections.Generic;
using SimpsonsDatabase.Models;

namespace SimpsonsDatabase.Data
{
	public class MockSimpsonsRepository : ISimpsonsRepository
	{

		private static List<CharacterModel> Simpsons = new List<CharacterModel>
		{
			new CharacterModel()
			{
				Id = Guid.NewGuid(),
				FirstName = "Homer",
				LastName = "Simpson",
				Age = 36,
				Gender = Gender.Male,
				Description = "Homer works as a low level safety inspector at the Springfield Nuclear Power Plant, in Sector 7G, although he is often incompetent and mostly sleeps on duty and eats the donuts that are provided. He spends a great deal of his time at Moe's Tavern with his lifelong friends Barney, Carl, Lenny, and bartender Moe. At his home, he can often be found sitting on the couch mindlessly watching TV while snacking on food and drinking Duff. Homer is the only son of Abe and Mona."
			},
			new CharacterModel()
			{
				Id = Guid.NewGuid(),
				FirstName = "Marge",
				LastName = "Simpson",
				Age = 34,
				Gender = Gender.Female,
				Description = "Marjorie Jacqueline \"Marge\" Simpson (née Bouvier) is the homemaker and full-time mom of the Simpson family. She and her husband Homer have three children: Bart, Lisa, and Maggie. Marge is the moralistic force in her family and often provides a grounding voice in the midst of her family's antics by trying to maintain order in the Simpson household. Aside from her duties at home, Marge has flirted briefly with a number of careers ranging from police officer to anti-violence activist."
			},
			new CharacterModel()
			{
				Id = Guid.NewGuid(),
				FirstName = "Bart",
				LastName = "Simpson",
				Age = 10,
				Gender = Gender.Male,
				Description = "Bartholomew JoJo \"Bart\" Simpson (born April 1/February 23), also known as \"El Barto,\" \"The boy\" (Homer Simpson), and \"Bartman,\" is the tritagonist of The Simpsons. He is the mischievous, rebellious, misunderstood and \"potentially dangerous\" eldest child of Homer and Marge Simpson, and the older brother of Lisa and Maggie. He also has been nicknamed Cosmo, after discovering a comet in \"Bart's Comet\". Bart's also been on the cover on numerous comics, such as \"Critical Hit\", \"Simpsons Treasure Trove #11\" and \"Winter Wingding\". Bart also has a whole comic series known as the Simpson Comics Presents Bart Simpson. Bart is loosely based on Matt Groening and his older brother, Mark."
			},
			new CharacterModel()
			{
				Id = Guid.NewGuid(),
				FirstName = "Lisa",
				LastName = "Simpson",
				Age = 8,
				Gender = Gender.Female,
				Description = "Lisa Marie Simpson (born May 9th) is the tetartagonist of The Simpsons. She was named after a train called Lil' Lisa on her parents' 1st anniversary. She is a charismatic 8-year-old girl, who exceeds the standard achievement of intelligence level of children her age. Not to everyone's surprise, she is also the moral center of her family. In her upbringing, Lisa lacks parental involvement of Homer and Marge, which leads to hobbies such as playing saxophone and guitar, riding and caring for horses, and interest in advanced studies. In school, Lisa's popularity is affected by those who view her as a geeky overachiever, which leaves her with only a few friends. She focuses on her goals and strives to reach her potential, and at the age of eight she is already a member of MENSA with an IQ of 159."
			},
			new CharacterModel()
			{
				Id = Guid.NewGuid(),
				FirstName = "Maggie",
				LastName = "Simpson",
				Age = 1,
				Gender= Gender.Female,
				Description = "Margaret Evelyn \"Maggie\" Simpson is the youngest child of Marge and Homer, and the baby sister to Bart and Lisa. She is often seen sucking on her pacifier, and, when she walks, she trips over her clothing and falls on her face. Because she rarely ever talks, Maggie is the least seen and heard in the Simpson family."
			}
		};

		public IList<CharacterModel> GetAllSimpsons()
		{
			return Simpsons;
		}

		public CharacterModel GetSimpsonById(Guid id)
		{
			return Simpsons.Find((obj) => obj.Id == id);
		}
	}
}
