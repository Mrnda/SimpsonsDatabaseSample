using System;
using System.Collections.Generic;
using SimpsonsDatabase.Models;

namespace SimpsonsDatabase.Data.Repositories.Base
{
	public interface ISimpsonsRepository
	{
		IList<CharacterModel> GetAllSimpsons();
		CharacterModel GetSimpsonById(Guid id);
	}
}
