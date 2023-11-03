using CrazyBook.DataAccess.Repository.IRepository;
using CrazyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBook.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }

        public bool HasAssociatedProducts(int id)
        {
            var HassociatedProducts = _db.Products.Where(p => p.CategoryId == id).Any();
            return HassociatedProducts;
        }

        public void Remove(int id)
        {
            var category = _db.Categories.Find(id);
            if(category != null)
            {

                if (HasAssociatedProducts(id))
                {
                    category.IsDisponible = false;
                    this.Update(category);
                }
                else
                {
                    base.Remove(category);
                }


            }
        }

        public IEnumerable<SelectListItem> ListCategoriesDisponible()
        {
            var categoriesDisponibleList = _db.Categories.Where(zt => zt.IsDisponible == true).OrderBy(c => c.Name)
            .Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            }).OrderBy(c => c.Text);

            return categoriesDisponibleList;
        }

        public IEnumerable<SelectListItem> ListAllCategories()
        {
            var categoriesDisponibleList = _db.Categories.OrderBy(c => c.Name)
           .Select(c => new SelectListItem
           {
               Text = c.Name,
               Value = c.Id.ToString()
           }).OrderBy(c => c.Text);

            return categoriesDisponibleList;
        }
    }
}
