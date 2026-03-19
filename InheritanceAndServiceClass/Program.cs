using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using InheritanceAndServiceClass.AppServices.Services;
using InheritanceAndServiceClass.Core.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace InheritanceAndServiceClass
{
    internal class Program 
    {
        private readonly ICarServices _carServices;

        public Program
            (
            ICarServices carServices
            )
        {
            _carServices = carServices;
        }

        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<ICarServices, CarServices>();

            var app = builder.Build();

            Console.WriteLine("Hello, World switch!");
            Console.WriteLine("Mida tahad teha? 1 on GetData, 2 on PostData, 3 on Putdata, 4 on DeleteData");
            int choice = int.Parse(Console.ReadLine());
            
            using (var scope = app.Services.CreateScope())
            {
                var carServices = scope.ServiceProvider.GetRequiredService<ICarServices>();
                var program = new Program(carServices);
                switch (choice)
                {
                    
                    case 1:
                        program.GetAsync();
                        break;
                    case 2:
                        program.SaveAsync();
                        break;
                    case 3:
                        program.UpdateData();
                        break;
                    case 4:                       
                        program.EraseData();
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
            

        public IActionResult GetAsync()
        {
            _carServices.GetData();

            return View();
        }
        public IActionResult SaveAsync()
        {
            _carServices.PostData();
            return View();
        }
        public IActionResult UpdateData()
        {
            _carServices.PutData();
            return View();
        }
        public IActionResult EraseData()
        {
            _carServices.DeleteData();
            return View();
        }
        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
