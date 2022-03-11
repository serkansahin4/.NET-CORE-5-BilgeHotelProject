using BilgeHotel.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class Role : IdentityRole<int>,IEntity
    {
        

        //public virtual List<Employee> Employees { get; set; }
    }
}
