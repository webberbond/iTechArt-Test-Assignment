using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoCSV;

namespace CsvParser
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadCsvFile();
            Console.ReadKey();
        }

        private static void ReadCsvFile()
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ';',
                UseFieldIndexForReadingData = false
            };

            var csvContext = new CsvContext();
            var players = csvContext.Read<Players>("Top100ChessPlayers.csv", csvFileDescription);
            foreach(var player in players)
            {
                if (player.B_Year > 1980 && (player.Rank > 0 && player.Rank < 11))
                {
                    Console.WriteLine($" {player.Rank} | {player.Name} | {player.Title} | {player.Country} | {player.Rating} | {player.Games} |{player.B_Year}");
                }            
            }              
        }
    }
}
