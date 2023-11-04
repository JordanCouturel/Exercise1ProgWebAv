using Jungle_DataAccess.Repository.IRepository;
using Jungle_Models.Models;


namespace Jungle_Web.Repository.IRepository
{
    public interface IReservationRepository:IRepository<Reservation>
    {
        public Task Update(Reservation entity);


    }
}
