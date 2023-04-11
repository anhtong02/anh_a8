using Communications;
using Logger;
using System.Text.Json;

namespace TowardAgarioStepThree
{
    public class Program
    {
        private static Networking networking;

        public static void Main(string[] args)
        {
            networking = new Networking(new CustomFileLogger("Debug"), onConnect, onDisconnect, onMessage, '\n');
            
                networking.Connect("localhost", 11000);
                networking.AwaitMessagesAsync();            
                Console.ReadLine();
              

            
        }

        private static void onConnect(Networking channel)
        {

        }

        private static void onDisconnect(Networking channel)
        {

        }

        private static void onMessage(Networking channel, string message)
        {

            if (message.StartsWith(AgarioModels.Protocols.CMD_Food))
            {
                string output = message.Substring(AgarioModels.Protocols.CMD_Food.Length);
                List<Food> listOfFood = new List<Food>();
                List<Food> foods = JsonSerializer.Deserialize<List<Food>>(output)
                    ?? throw new Exception("Error of Json");

                foreach (var food in foods)
                {
                    Console.WriteLine($"Food: {food.ARGBColor}");
                }
            }

            if (message is null)
            {
                Console.WriteLine("null");
            }
        }
    }
}