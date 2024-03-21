using System.IO;
namespace A1Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "tickets(1).csv";
            string choice;

            do
            {
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("Enter any other key to exit.");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    ReadFile(file);
                }
                else if (choice == "2")
                {

                }
            } while (choice == "1" || choice == "2");

        }

        private static void ReadFile(string file)
        {
            if (File.Exists(file))
            {
                StreamReader sr = new StreamReader(file);

                while (!sr.EndOfStream)
                {
                    var row = sr.ReadLine();
                    var columns = row.Split('|');

                    Console.WriteLine("TicketID: {0}, Summary{1}, Status{2}, Priority{3}, Submitter{4}, Assigned{5}, Watching{6}",columns[0], columns[1], columns[2], columns[3], columns[4], columns[5], columns[6]);
                }

            }
            else
            {
                Console.WriteLine("File does not exist!");
            }
        }

    }
}

        