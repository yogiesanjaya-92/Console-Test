using EntityFramework.DAL;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static List<Game_Logger> getLogWithSP(GameLoggerContext db)
        {
            //Call Stored Procedure     
            var gameTitle = new SqlParameter("@Game", SqlDbType.VarChar, 50) { Value = "PES" };
            var result = db.Database.SqlQuery<Game_Logger>("SELECT_LOG_BY_GAME @Game", gameTitle).ToList();
            return result;
        }

        static List<Game_Logger> getLogWithPredicate(GameLoggerContext db)
        {
            //Using Predicate Builder
            var predicate = PredicateBuilder.New<Game_Logger>(true);
            predicate = predicate.And(x => x.Last_Name != null && x.Last_Name != string.Empty);

            //Result Order, Skip and Take
            var result = db.GameLogger.Where(predicate)
                            .OrderBy(x => x.First_Name)
                            .ThenBy(x => x.Last_Name)
                            .Skip(0).Take(5).ToList();

            return result;
        }

        static void showSelctedLogger(List<Game_Logger> res)
        {
            Console.WriteLine("Show selected player in the database:");
            foreach (var item in res)
            {
                Console.WriteLine(string.Format("{0} {1} - {2} : {3}", item.First_Name, item.Last_Name, item.Game, item.Hours));
            }
        }

        static void Main(string[] args)
        {
            using (var db = new GameLoggerContext())
            {
                //Create and save a new Log
                Console.Write("Enter a first name for a new Log: ");
                var firstName = Console.ReadLine();
                Console.Write("Enter a last name for a new Log: ");
                var lastName = Console.ReadLine();

                var ID = Guid.NewGuid();

                var gameLog = new Game_Logger();
                gameLog.ID = ID;
                gameLog.First_Name = firstName;
                gameLog.Last_Name = lastName;
                gameLog.Game = "Tester Logger";
                gameLog.Hours = 1;
                db.GameLogger.Add(gameLog);
                db.SaveChanges();

                // Display all Player from the database
                var res = db.GameLogger.OrderBy(x => x.First_Name).ThenBy(x => x.Last_Name).ToList();

                Console.WriteLine("All player in the database:");
                foreach (var item in res)
                {
                    Console.WriteLine(string.Format("{0} {1} - {2} : {3}", item.First_Name, item.Last_Name, item.Game, item.Hours));
                }

                //Update player name
                Console.Write("Enter a first name to update Log: ");
                firstName = Console.ReadLine();
                Console.Write("Enter a last name to update Log: ");
                lastName = Console.ReadLine();

                var selectedGameLog = db.GameLogger.Find(ID);
                if (!string.IsNullOrWhiteSpace(firstName))
                {
                    selectedGameLog.First_Name = firstName;
                    selectedGameLog.Last_Name = lastName;
                    db.SaveChanges();
                }

                // Display all Player from the database
                res = db.GameLogger.OrderBy(x => x.First_Name).ThenBy(x => x.Last_Name).ToList();

                Console.WriteLine("All player in the database:");
                foreach (var item in res)
                {
                    Console.WriteLine(string.Format("{0} {1} - {2} : {3}", item.First_Name, item.Last_Name, item.Game, item.Hours));
                }

                //Remove
                Console.Write("Are you want to delete the log(y/n): ");
                var answer = Console.ReadLine();
                if (answer.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                {
                    db.GameLogger.Remove(selectedGameLog);
                    db.SaveChanges();
                }

                // Display all Player from the database
                res = db.GameLogger.OrderBy(x => x.First_Name).ThenBy(x => x.Last_Name).ToList();

                Console.WriteLine("All player in the database:");
                foreach (var item in res)
                {
                    Console.WriteLine(string.Format("{0} {1} - {2} : {3}", item.First_Name, item.Last_Name, item.Game, item.Hours));
                }

                Console.ReadKey();
                showSelctedLogger(getLogWithSP(db));

                Console.ReadKey();
                showSelctedLogger(getLogWithPredicate(db));

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
