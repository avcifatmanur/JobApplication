using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager(new EfPersonDal());
            BoroughManager boroughManager = new BoroughManager(new EfBoroughDal());

            Person person = personManager.GetById(2);
            Console.WriteLine(person.Description);

           // var boroughs=boroughManager.GetDetailsByCityId(6);
           // Console.WriteLine(boroughs);

            foreach (var x in boroughManager.GetDetailsByCityId(6))
            {
                Console.WriteLine(x.BoroughName);
            }

            foreach (var staff in personManager.GetAll())
            {
                Console.WriteLine(staff.FirstName_LastName);
            }
           

        }
    }
}
