namespace CrowdChat.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CrowdChat.Models;
    using CrowdChat.Data;

    class Program
    {
        static void Main(string[] args)
        {
            var data = new MongoDbContext();

            var user = new User("Pesho");
            var msg = new Message{ Content = "Hello", PostedOn = DateTime.Now, PostedBy = user.Name };

            data.Insert(msg);

            Console.WriteLine(data.GetMessagesSince(DateTime.Today));


        }
    }
}
