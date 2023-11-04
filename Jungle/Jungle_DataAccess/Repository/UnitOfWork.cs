using Jungle_DataAccess.Data;
using Jungle_DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly JungleDbContext _db;

        public UnitOfWork(JungleDbContext db)
        {
            _db = db;

            Country = new CountryRepository(db);
            Destination = new DestinationRepository(db);
            Guide = new GuideRepository(db);
            Travel = new TravelRepository(db);
            TravelRecommendation = new TravelRecommendationRepository(db);


        }

        public ICountryRepository Country { get; private set; }

        public IDestinationRepository Destination { get; private set; }

        public IGuideRepository Guide { get; private set; }

        public ITravelRepository Travel { get; private set; }

        public ITravelRecommendationRepository TravelRecommendation { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }



    }
    }
