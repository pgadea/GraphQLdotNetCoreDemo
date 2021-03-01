using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphQLProject.Services
{
    public class ReservationService : IReservation
    {
        private readonly GraphQLDbContext _dbContext;

        public ReservationService(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Reservation AddReservation(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
            return reservation;
        }

        public List<Reservation> GetReservations()
        {
           return _dbContext.Reservations.ToList();
        }
    }
}
