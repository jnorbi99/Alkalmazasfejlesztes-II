using System.Data.SQLite;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    public class GameDAOImp : GameDAO
    {
        private const string CONN_STRING = @"Data Source=../../../../DB/nfl.db";

        public bool AddGame(Game game)
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "insert into Game "
                                   + "(HomeClubName, AwayClubName, HomeFinalScore, AwayFinalScore, HomeNumberOfTD, AwayNumberOfTD, Week, Year) values "
                                   + "(@homeClubName, @awayClubName, @homeFinalScore, @awayFinalScore, @homeNumberOfTD, @awayNumberOfTD, @week, @year);";

            command.Parameters.Add("homeClubName", System.Data.DbType.String).Value = game.HomeClubName;
            command.Parameters.Add("awayClubName", System.Data.DbType.String).Value = game.AwayClubName;
            command.Parameters.Add("homeFinalScore", System.Data.DbType.Int32).Value = game.HomeFinalScore;
            command.Parameters.Add("awayFinalScore", System.Data.DbType.Int32).Value = game.AwayFinalScore;
            command.Parameters.Add("homeNumberOfTD", System.Data.DbType.Int32).Value = game.HomeNumberOfTD;
            command.Parameters.Add("awayNumberOfTD", System.Data.DbType.Int32).Value = game.AwayNumberOfTD;
            command.Parameters.Add("week", System.Data.DbType.Int32).Value = game.Week;
            command.Parameters.Add("year", System.Data.DbType.Int32).Value = game.Year;

            bool ret = true;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ret = false;
            }

            connection.Close();
            return ret;
        }

        public IEnumerable<Game> GetGames()
        {
            List<Game> games = new List<Game>();

            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "select * from Game";

            using var reader = command.ExecuteReader();

            while(reader.Read())
            {
                games.Add(new Game
                {
                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                    HomeClubName = reader.GetString(reader.GetOrdinal("HomeClubName")),
                    AwayClubName = reader.GetString(reader.GetOrdinal("AwayClubName")),
                    HomeFinalScore = reader.GetInt32(reader.GetOrdinal("HomeFinalScore")),
                    AwayFinalScore = reader.GetInt32(reader.GetOrdinal("AwayFinalScore")),
                    HomeNumberOfTD = reader.GetInt32(reader.GetOrdinal("HomeNumberOfTD")),
                    AwayNumberOfTD = reader.GetInt32(reader.GetOrdinal("AwayNumberOfTD")),
                    Week = reader.GetInt32(reader.GetOrdinal("Week")),
                    Year = reader.GetInt32(reader.GetOrdinal("Year")),
                });
            }

            connection.Close();
            return games;
        }

        public bool ModifyGame(Game game)
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "update Game set "
                                   + "HomeFinalScore=@homeFinalScore, AwayFinalScore=@awayFinalScore, "
                                   + "HomeNumberOfTD=@homeNumberOfTD, AwayNumberOfTD=@awayNumberOfTD "
                                   + "where ID=@id;";

            command.Parameters.Add("homeFinalScore", System.Data.DbType.Int32).Value = game.HomeFinalScore;
            command.Parameters.Add("awayFinalScore", System.Data.DbType.Int32).Value = game.AwayFinalScore;
            command.Parameters.Add("homeNumberOfTD", System.Data.DbType.Int32).Value = game.HomeNumberOfTD;
            command.Parameters.Add("awayNumberOfTD", System.Data.DbType.Int32).Value = game.AwayNumberOfTD;
            command.Parameters.Add("id", System.Data.DbType.Int32).Value = game.ID;

            bool ret = true;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ret = false;
            }

            connection.Close();
            return ret;
        }
    }
}
