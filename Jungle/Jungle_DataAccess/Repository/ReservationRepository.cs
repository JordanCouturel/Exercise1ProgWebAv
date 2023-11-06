using Jungle_Models.Models;
using Jungle_Web.Repository.IRepository;
using System.Linq.Expressions;

//using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Newtonsoft.Json.Linq;
using Jungle_DataAccess.Data;

namespace Jungle_DataAccess.Repository
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {

        public JungleDbContext context { get; set; }
        double Prix;
        const double Rabais20 = 0.80;
        const double Rabais15 = 0.85;


        public ReservationRepository(JungleDbContext db) : base(db)
        {
            context = db;
        }

        public Task Update(Reservation entity)
        {
            throw new NotImplementedException();
        }










        public void Reserver(Travel travel,int nbplaces)
        {

            double PrixPourLesOptions = 0;
            Reservation reservation = new Reservation();
         

            int NbPersonnesAdditionelles = CalculPlaces(nbplaces);

            double prixPourLesAdditional = (travel.Price * 0.80) * NbPersonnesAdditionelles; 
         



            
            if (DepartureDatePlusGrand(travel) && travel.DepartureDate <= DateTime.Now.AddDays(14) && travel.NbPlaceDispo-nbplaces>=0)
            {

                for(int i=0; i<=3; i++)
                {
                    PrixPourLesOptions += reservation.Options[i].Price;
                }


                reservation.PrixFinal = (travel.Price + prixPourLesAdditional) * 0.85 + PrixPourLesOptions;

                context.Reservations.Add(reservation);

            }
            else
            {
                reservation.PrixFinal = travel.Price + prixPourLesAdditional + PrixPourLesOptions;

            }




        }


     



        //Fonction pour verifier si la dtae de reservation est valide
        public bool DepartureDatePlusGrand(Travel travel)
        {


            //Regles d affaires 1
            if (DateTime.Now.Date >= travel.DepartureDate)
            {
                return false;
            }

       


            return true;

        }






        ////Fonction pour verifier si la dtae de reservation est valide
        //public int CalculRabaisPlaces(int nbPlaces)
        //    {
        //        int nbPlacesAdditionnelles = 0;


        //        //Regles d affaires 4
        //        if (nbPlaces > 1)
        //        {
        //            nbPlacesAdditionnelles = nbPlaces - 1;
        //        }




        //        return nbPlacesAdditionnelles;
        //    }





        //Fonction pour verifier si la dtae de reservation est valide
        public int CalculPlaces(int nbPlaces)
        {
            int nbPlacesAdditionnelles = 0;

            //Regles d affaires 4
            if (nbPlaces > 1)
            {
                nbPlacesAdditionnelles = nbPlaces - 1;
            }



            return nbPlacesAdditionnelles;
        }





        public double CalculRabais(Travel travel)
        {
            double rabais = 0;


            //Regles d affaires 2
            if (DateTime.Now.AddDays(14) < travel.DepartureDate)
            {

                rabais = 15;
            }


            return rabais;

        }

































    }
} 


