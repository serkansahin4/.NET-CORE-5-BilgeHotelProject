using BilgeHotel.Business.Abstract;
using BilgeHotel.Business.Concrete;
using BilgeHotel.Core.MyTools.Abstract;
using BilgeHotel.Core.MyTools.Concrete;
using BilgeHotel.DataAccess.Abstract;
using BilgeHotel.DataAccess.EntityFramework;
using BilgeHotel.DataAccess.EntityFramework.Context;
using BilgeHotel.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.IocContainer
{
    public static class IocContainer
    {
        public static void IocConfiguration(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(EfEntityRepository<>)); //Scope Olmasının Sebebi
                                                                          //İçerisindeki operasyonları her kullanan kişi
                                                                          //İçin yeniden bir newleme yapmaması.
                                                                          //Same(Aynı) Instance    New ınstance
                    
            services.AddScoped<IBedService, BedManager>();                        //Servisler İstekler doğrultusunda
                                                               //Ayağa Kaldırıldığı için Transient
                                                               //New Instance
                                                             //New Instance
                    
            services.AddScoped<IDateManagementExtension, DateManagementExtension>();
                    
            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<IPackageService, PackageManager>();
            services.AddScoped<ICardService, CardManager>();
                    
            services.AddScoped<IDepartmentService, DepartmentManager>();
                    
            services.AddScoped<IExtraService, ExtraManager>();
                    
            services.AddScoped<IHotelExtraService, HotelExtraManager>();
                    
            services.AddScoped<IReservationOutHotelExtraService, ReservationOutHotelExtraManager>();
                    
            services.AddScoped<IRoomBedService, RoomBedManager>();
            services.AddScoped<IRoomTypeService, RoomTypeManager>();
            services.AddScoped<IRoomService, RoomManager>();
            services.AddScoped<IRoomTypeExtraService, RoomTypeExtraManager>();
            services.AddScoped<IRoomViewService, RoomViewManager>();
            services.AddScoped<IRoomSituationService, RoomSituationManager>();
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDetailService, ReservationDetailManager>();
                    
            services.AddScoped<IImageService, ImageManager>();
            services.AddScoped<IImageExtension, ImageExtension>();
                    
            services.AddScoped<IEmployeeJobService, EmployeeJobManager>();
            services.AddScoped<IShiftTimeService, ShiftTimeManager>();
            services.AddScoped<IShiftService, ShiftManager>();
            services.AddScoped<IJobService, JobManager>();


            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Images Gelicek.
            //SHIFT gelicek
        }

        public static void DbConfigurationAdd(this IServiceCollection services, IConfiguration configuration)
        {
            //, x => x.MigrationsAssembly("BilgeHotel.WebUI")
            services.AddDbContext<BilgeHotelDenemeContext>(x => x.UseSqlServer(configuration.GetConnectionString("DefaultConnection")).UseLazyLoadingProxies());
            services.AddIdentity<Employee, Role>(x => {
                x.Password.RequiredLength = 4;
                x.Password.RequireDigit = false;
                x.Password.RequireUppercase = false;
                x.Password.RequireLowercase = false;
                x.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<BilgeHotelDenemeContext>();
        }
    }
}
