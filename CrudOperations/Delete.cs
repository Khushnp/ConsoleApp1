using ConsoleApp1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CrudOperations
{
    internal class Delete
    {
        TrainingDB2Context context = new TrainingDB2Context();
        public void DeletFirstRecord()
        {

            Author1 del = new Author1();

            del = context.Author1s.First();
            context.Author1s.Remove(del);
            context.SaveChanges();

        }

        /*        public void DisplayRecords()
                {
                    var records = context.Author1s.ToList();
                    foreach (var record in records)
                    {
                        Console.WriteLine(record.Ipaddress + " " + record.Email + record.LastName + record.FirstName + record.AddedDate + record.ModifiedDate);
                    }
                }*/
    }

}
