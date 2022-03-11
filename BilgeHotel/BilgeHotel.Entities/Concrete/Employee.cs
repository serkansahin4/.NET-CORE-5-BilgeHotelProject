using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.ComplexType;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class Employee :IdentityUser<int>, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public double Salary { get; set; }

        public virtual List<Reservation> Reservations { get; set; }

        


        public virtual EmployeeJob EmployeeJob { get; set; }
    }
}
