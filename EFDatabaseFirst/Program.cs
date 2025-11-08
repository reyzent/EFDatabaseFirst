using System;
using System.Linq;

namespace EFDatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (userstoredbEntities db = new userstoredbEntities())
            {
                var users = db.Users;
                foreach (User u in users)
                    Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
            }

            Console.ReadKey();
        }
    }
}