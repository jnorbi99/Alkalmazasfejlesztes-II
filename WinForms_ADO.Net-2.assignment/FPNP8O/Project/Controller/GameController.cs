using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAO;
using Project.Model;

namespace Project.Controller
{
    public class GameController
    {
        private readonly GameDAOImp dao;

        public GameController(GameDAOImp gameDao)
        {
            dao = gameDao;
        }

        public bool AddGame(Game game)
        {
            return dao.AddGame(game);
        }

        public bool ModifyGame(Game game) 
        {
            return dao.ModifyGame(game);
        }
        public IEnumerable<Game> GetGames()
        {
            return dao.GetGames();
        }
    }
}
