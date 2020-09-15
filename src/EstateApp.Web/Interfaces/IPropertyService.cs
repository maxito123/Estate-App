using System.Collections.Generic;
using System.Collections;
using System.Security.AccessControl;
using System.Threading.Tasks;
using EstateApp.Web.Models;
using EstateApp.Data.Entities;

namespace EstateApp.Web.Interfaces
{
    public interface IPropertyService
    {
        Task AddProperty(PropertyModel model );

        IEnumerable<Property> GetAllProperties();
    }
}