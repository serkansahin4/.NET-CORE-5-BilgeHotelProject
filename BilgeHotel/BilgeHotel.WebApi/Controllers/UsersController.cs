using BilgeHotel.Entities.Concrete;
using BilgeHotel.WebApi.Models.NewViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,InsanKaynaklariYoneticisi")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<Employee> _userManager;
        private readonly RoleManager<Role> _roleManager;
        public UsersController(UserManager<Employee> user, RoleManager<Role> roleManager)
        {
            _userManager = user;
            _roleManager = roleManager;
        }

        [HttpPost("DefaultUserCreate")] //OTOMATİKMAN VERİTABANINA 4 TANE KULLANICI,Rol VE Kullanıcı ROLLERİNİ EKLER.

        public async Task<IActionResult> DefaultUserCreate()
        {
            List<Employee> employees = new List<Employee> {
            new Employee { Adress = "Sırasöğütler",UserName="osmanab", FirstName = "Osman", PhoneNumberConfirmed=true, EmailConfirmed=true, TwoFactorEnabled=false, LockoutEnabled=false, LastName = "Şahin", Phone = "12345678955", Salary = 500, Email = "b1serkana60@gmail.com" },
               new Employee {  Adress = "Sırasöğütler",UserName="muratab", FirstName = "Murat", LastName = "Şahin", Phone = "12345678955", Salary = 100, Email = "b1osmana60@gmail.com" },
               new Employee { Adress = "Sırasöğütler",UserName="mehmeteb", FirstName = "Mehmet", LastName = "Şahin", Phone = "12345678955", Salary = 200, Email = "b1mustafa60@gmail.com" },
               new Employee { Adress = "Sırasöğütler",UserName="gayeeb", FirstName = "Gaye", LastName = "Şahin", Phone = "12345678955", Salary = 200, Email = "b1mehmet@gmail.com" }
               };

            List<Role> roles = new List<Role> {
            new Role { Name = "SatisDepartmaniYoneticisi" },
                new Role {  Name = "InsanKaynaklariYoneticisi" },
                new Role { Name = "ITSorumlusu" },
                new Role { Name = "ResepsiyonSefi" }
            };
            int sayac = 0;
            foreach (var item in employees)
            {
                await _userManager.CreateAsync(item, "12345633+Bjk");
                await _roleManager.CreateAsync(roles[sayac]);
                Employee employee = await _userManager.FindByEmailAsync(item.Email);
                await _userManager.AddToRoleAsync(employee, roles[sayac].Name);
                sayac++;
            }




            return Ok();
        }

        [HttpPost("{password}")] //USER EKLE
        public async Task<IActionResult> AddUser([FromBody] Employee employee, string password)
        {
            await _userManager.CreateAsync(employee, password);
            return Ok();
        }
        [HttpPut] //USER GÜNCELLEme
        public async Task<IActionResult> UpdateUser([FromBody] Employee employee)
        {
            await _userManager.UpdateAsync(employee);
            return Ok();
        }
        [HttpGet("GetByEmail/{email}")] //Bir Kullanıcı Getirme
        public IActionResult GetByEmail(string email)
        {
            Employee employee = _userManager.Users.SingleOrDefault(x => x.Email == email);
            return Ok(employee);
        }
        [HttpGet] //Bütün Kullanıcıları getirme
        public IActionResult Get()
        {
            List<EmployeeGetVM> employee = _userManager.Users.ToList().Select(x => new EmployeeGetVM { Email = x.Email, EmployeeId = x.Id, FirstName = x.FirstName, LastName = x.LastName }).ToList();
            string serialEmployee = JsonConvert.SerializeObject(employee);
            return Ok(serialEmployee);
        }

        [HttpGet("GetUserRoles/{id}")] //Kullanıcı Rollerini Getirme
        public async Task<IActionResult> GetUserRoles(int id)
        {
            Employee employee = _userManager.Users.SingleOrDefault(x => x.Id == id);
            IList<string> roles = await _userManager.GetRolesAsync(employee);
            return Ok(roles);
        }

        [HttpPost]
        [Route("[action]")]  //KULLANICIYA ROL EKLEME
        public async Task<IActionResult> CreateUserRoles([FromBody] CreateUserRoleVM createUserRoleVM)
        {
            Employee employee = await _userManager.FindByIdAsync(createUserRoleVM.EmployeeId);
            IdentityResult kontrol = await _userManager.AddToRoleAsync(employee, createUserRoleVM.RoleName);
            if (kontrol.Succeeded)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Geçerli Bir Role Gir.");
            }

        }
        [HttpPost]
        [Route("[action]")]  //KULLANICININ ROLLERİNİ SİLME
        public async Task<IActionResult> DeleteUserRole([FromBody] CreateUserRoleVM createUserRoleVM)
        {
            Employee employee = await _userManager.FindByIdAsync(createUserRoleVM.EmployeeId);
            IdentityResult kontrol = await _userManager.RemoveFromRoleAsync(employee, createUserRoleVM.RoleName);
            if (kontrol.Succeeded)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Geçerli Bir Role Gir.");
            }

        }


    }
}
