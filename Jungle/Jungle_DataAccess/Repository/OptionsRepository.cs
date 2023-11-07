using Jungle_DataAccess.Data;
using Jungle_DataAccess.Repository.IRepository;
using Jungle_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_DataAccess.Repository
{
    public class OptionsRepository:IOptionsRepository
    {

        public JungleDbContext Context { get; set; }
        public OptionsRepository(JungleDbContext _context) 
        {
            Context = _context;
        }



   


        public void Add(Travel travel,Option option)
        {
            if(travel.Options.Count<6)
            {
                travel.Options.Add(option);
            }

            
        }


        public void Delete(Option option)
        {
            if (option.EstChoisi)
            {
                throw new Exception(message: "Impossible");
            }
            else
            {
                Context.Remove(option);
            }
        }


    }
}
