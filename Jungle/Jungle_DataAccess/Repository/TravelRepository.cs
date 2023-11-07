using Jungle_DataAccess.Data;
using Jungle_DataAccess.Repository.IRepository;
using Jungle_Models.Models;


namespace Jungle_DataAccess.Repository
{
    public class TravelRepository:Repository<Travel>, ITravelRepository
    {
        private readonly JungleDbContext _db;

        public TravelRepository(JungleDbContext db):base(db)
        {
            _db = db;
        }

        public void Update(Travel travel)
        {
            _db.Update(travel);
        }




        public void Create(Travel travel)
        {
            if (travel.DepartureDate >= DateTime.Now.AddDays(45))
            {

                _db.Travels.Add(travel);
            }
            else
                throw new Exception(message: "Impossible d'ajouter ce voyage");
        }






    }
}
