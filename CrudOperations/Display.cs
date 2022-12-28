using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CrudOperations
{
    internal class Display
    {
        public void DiplayAll()
        {
            var context = new TrainingDB2Context();
            var data = context.Author1s.ToList();
            foreach (var record in data)
            {
                Console.WriteLine(record.Ipaddress + " " + record.Email + " " + record.LastName + " " + record.FirstName + " " + record.AddedDate + " " + record.ModifiedDate + " ");
            }
        }
    }
}
