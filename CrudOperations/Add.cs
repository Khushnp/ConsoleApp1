using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CrudOperations
{
    internal class Add
    {
        TrainingDB2Context context = new TrainingDB2Context();
        public void AddRecord()
        {
            Console.WriteLine("Hello");
            Author1 AOBJ = new Author1();

            AOBJ.AddedDate = DateTime.Now;
            AOBJ.FirstName = "KHUSH";
            AOBJ.LastName = "abc";
            AOBJ.Email = "ABC";
            AOBJ.Ipaddress = 101547;
            AOBJ.ModifiedDate = DateTime.Now;


            context.Author1s.AddRange(AOBJ);
            context.SaveChanges();
        }

        /*public void Display()
        {
            var data=context.Author1s.ToList();

            foreach(var item in data)
            {
                Console.WriteLine(item.FirstName+item.LastName+item.Ipaddress);
            }
        }*/

        /*public void delete()
        {
           var rec= context.Author1s.First();
            context.Remove(rec);
            context.SaveChanges();
        }*/
    }
}
