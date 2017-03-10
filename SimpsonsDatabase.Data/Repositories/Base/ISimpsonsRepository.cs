using System;
using System.Collections.Generic;
using SimpsonsDatabase.Models;

namespace SimpsonsDatabase.Data
{
	public interface ISimpsonsRepository
	{
		IList<CharacterModel> GetAllSimpsons();
		CharacterModel GetSimpsonById(Guid id);
	}
}
