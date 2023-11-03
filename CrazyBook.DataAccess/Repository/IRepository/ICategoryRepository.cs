using CrazyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBook.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        public IEnumerable<SelectListItem> ListCategoriesDisponible();

        public IEnumerable<SelectListItem> ListAllCategories();

        void Update(Category obj);

        void Remove(int id);

        public bool HasAssociatedProducts(int id);

    }
}
