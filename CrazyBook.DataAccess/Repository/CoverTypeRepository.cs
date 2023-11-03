using CrazyBook.DataAccess.Repository.IRepository;
using CrazyBook.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBook.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(CoverType obj)
        {
            _db.CoverTypes.Update(obj);
        }

        public IEnumerable<SelectListItem> ListAllCoverTypes()
        {
            var coverTypesList = _db.CoverTypes.OrderBy(c => c.Name)
           .Select(c => new SelectListItem
           {
               Text = c.Name,
               Value = c.Id.ToString()
           }).OrderBy(c => c.Text);

            return coverTypesList;
        }
    }
}
