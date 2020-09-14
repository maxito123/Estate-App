using System;
using System.Threading.Tasks;
using EstateApp.Data.DatabaseContexts.ApplicationDbContext;
using EstateApp.Data.Entities;
using EstateApp.Web.Interfaces;
using EstateApp.Web.Models;

namespace EstateApp.Web.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly ApplicationDbContext _dbContext;
        public PropertyService(ApplicationDbContext dbContext)
        {
           _dbContext = dbContext; 
        }         public async Task AddProperty(PropertyModel model)
        {
            var property = new Property
            {
                id = Guid.NewGuid().ToString(),
                Title = model.Title,
                Price = model.Price,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                NumberOfBaths = model.NumberOfBaths,
                NumberOfRooms = model.NumberOfRooms,
                NumberOfToilets = model.NumberOfToilets,
                Address = model.Address,
                ContactPhoneNumber =model.ContactPhoneNumber
            };
            await _dbContext.AddAsync(property);
            await _dbContext.SaveChangesAsync();
        }
    }
}