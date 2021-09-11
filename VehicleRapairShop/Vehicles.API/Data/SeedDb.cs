using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.API.Data.Entities;

namespace Vehicles.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckVehicleTypesAsync();
            await CheckBrandsAsync();
            await CheckDocumentTypesAsync();
            await CheckProceduresAsync();
        }

        private async Task CheckProceduresAsync()
        {
            if (!_context.Procedures.Any())
            {
                _context.Procedures.Add(new Procedures { Description = "Filter Change", Price = 150000 });
                _context.Procedures.Add(new Procedures { Description = "Liquid Moly Oil", Price = 200000});
                _context.Procedures.Add(new Procedures { Description = "Tires Change", Price = 400000 });
                _context.Procedures.Add(new Procedures { Description = "Castrol Oil", Price = 300000 });
                _context.Procedures.Add(new Procedures { Description = "Fuel pump change", Price = 250000 });
                _context.Procedures.Add(new Procedures { Description = "Dual clutch upgrade", Price = 600000 });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckDocumentTypesAsync()
        {
            if (!_context.DocumentTypes.Any())
            {
                _context.DocumentTypes.Add(new DocumentTypes { Description = "ID" });
                _context.DocumentTypes.Add(new DocumentTypes { Description = "Passport" });
                _context.DocumentTypes.Add(new DocumentTypes { Description = "Employment Authorization" });
                _context.DocumentTypes.Add(new DocumentTypes { Description = "Driver's License" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckBrandsAsync()
        {
            if (!_context.Brands.Any())
            {
                _context.Brands.Add(new Brands { Description = "Suzuki" });
                _context.Brands.Add(new Brands { Description = "Audi" });
                _context.Brands.Add(new Brands { Description = "Mercedez Benz" });
                _context.Brands.Add(new Brands { Description = "Kenworth" });
                _context.Brands.Add(new Brands { Description = "Ducati" });
                _context.Brands.Add(new Brands { Description = "Nissan" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckVehicleTypesAsync()
        {
            if (!_context.VehicleTypes.Any())
            {
                _context.VehicleTypes.Add(new VehicleType { Description = "Car" });
                _context.VehicleTypes.Add(new VehicleType { Description = "Bike" });
                await _context.SaveChangesAsync();
            }
        }


    }
}
