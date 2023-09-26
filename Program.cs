

using Microsoft.Data.Sqlite;
using System.Reflection;
using System.Text;
using QueryBuilder.Models;
using System.Diagnostics.Metrics;

namespace QueryBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dbPath = "../../../Data/data.db";
           QueryBuilder query = new QueryBuilder(dbPath);
            Pokemon p = new Pokemon();
            #region A.

            query.DeleteAll<Pokemon>(p);
            Console.WriteLine("Deleted all objects inside Pokemon Table\n\n");
            #endregion


            
            #region B.


            List<Pokemon> listP = new List<Pokemon>();
            Pokemon p1 = new Pokemon{ Id = 0, DexNumber = 0, Name = "Waaaa", Form = "N/A", Type1 = "N/A", 
                Type2 = "N/A", Total = 0, HP = 0, Attack = 0, Defense = 0, SpecialAttack = 0, SpecialDefense = 0, Speed = 0, Generation = 1 };
            listP.Add(p1);
                        Pokemon p2 = new Pokemon{ Id = 0, DexNumber = 100, Name = "Waaa", Form = "Prone", Type1 = "N/A", 
                Type2 = "N/A", Total = 0, HP = 0, Attack = 0, Defense = 0, SpecialAttack = 5, SpecialDefense = 0, Speed = 0, Generation = 1 };
            listP.Add(p2);
            Pokemon p3 = new Pokemon
            {
                Id = 0,
                DexNumber = 0,
                Name = "Waaaaa",
                Form = "N/A",
                Type1 = "N/A",
                Type2 = "N/A",
                Total = 0,
                HP = 0,
                Attack = 0,
                Defense = 0,
                SpecialAttack = 0,
                SpecialDefense = 0,
                Speed = 0,
                Generation = 1
            };
            listP.Add(p3);
            for (int i = 0; i <  listP.Count; i++)
            {

                query.Create(listP[i]);

            }
            Console.WriteLine("Inserted 3 new objects to the Pokemon table");
            List<BannedGame> listB = new List<BannedGame>();
            BannedGame b1 = new BannedGame { Id = 137, Title = "Book1", Series = "Book1", Country = "Book1", Details = "Book1" };
            BannedGame b2 = new BannedGame { Id = 137, Title = "Book2", Series = "Book2", Country = "Book2", Details = "Book2" };
            BannedGame b3 = new BannedGame { Id = 137, Title = "Book3", Series = "Book3", Country = "Book3", Details = "Book3" };
            listB.Add(b1);
            listB.Add(b2);
            listB.Add(b3);
            for (int i = 0; i < listB.Count; i++)
            {
                
                query.Create(listB[i]);

            }
            Console.WriteLine("Inserted 3 new objects to BannedGames table");


            #endregion

            #region C. 
            // public Pokemon(int id, int dexNumber, string name, string form, string type1, string type2, int total, int hP, int attack, int defense, int specialAttack, int specialDefense, int speed, int generation)
            Pokemon testP = new Pokemon { Id = 0, DexNumber = 0, Name = "Bubba", Form = "lad", Type1 = "Bubba", 
                Type2 = "Not a type", Total = 100, HP = 90, Attack = 12, Defense = 20, SpecialAttack = 15, SpecialDefense = 5, Speed = 3, Generation = 1 };   
            BannedGame testB = new BannedGame {Id = 0, Title = "Les Miserable", Country = "N/A", Details = "N/A", Series = "Les Miserable" };

            query.Create(testB);
            Console.WriteLine("Inserted book");
            query.Create(testP);
            Console.WriteLine("Inserted Pokemon");

            #endregion
            

        }

    }
}