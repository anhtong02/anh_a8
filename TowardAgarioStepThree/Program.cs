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
            try
            {
                networking.Connect("localhost", 11000);
                networking.AwaitMessagesAsync();
            }
            catch (Exception e)
            {
                Console.ReadLine();
                onMessage(networking, e.Message);
            }
        }

        private static void onConnect(Networking channel)
        {

        }

        private static void onDisconnect(Networking channel)
        {

        }

        private static void onMessage(Networking channel, string message)
        {
            if (message.StartsWith("{Command Food}"))
            {
                Console.WriteLine(message);
                string output = message.Substring(14);
                List<Food> listOfFood = new List<Food>();
                List<Food> foods = JsonSerializer.Deserialize<List<Food>>(output)
                    ?? throw new Exception("Error of Json");
            }
        }
    }
}