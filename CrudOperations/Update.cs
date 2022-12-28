using ConsoleApp1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CrudOperations
{
    internal class Update
    {
        TrainingDB2Context context = new TrainingDB2Context();
        public void UpdateRecord()
        {
            Author1 up = new Author1();
            up = context.Author1s.First();
            up.FirstName = "NewName";
            up.LastName = "NewLastName";
            up.Ipaddress = 11111;
            up.Email = "somethingnew@gmsi.com";
            context.SaveChanges();
        }

        /*public void UpdatedREcordDisplay()
        {
            var records = context.Author1s.ToList();
            foreach (var record in records)
            {
                Console.WriteLine(record.Ipaddress + " " + record.Email + " " + record.LastName + " " + record.FirstName + " "  + record.AddedDate + " " + record.ModifiedDate + " ");
            }
        }*/
    }

}
