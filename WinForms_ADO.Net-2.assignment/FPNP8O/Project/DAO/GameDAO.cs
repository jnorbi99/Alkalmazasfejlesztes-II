using Project.Model;
using System.Collections.Generic;

namespace Project.DAO
{
	public interface GameDAO
    {
        bool AddGame(Game game);
        bool ModifyGame(Game game);
        IEnumerable<Game> GetGames();
    }
}