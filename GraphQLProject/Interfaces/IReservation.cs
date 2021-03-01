using GraphQLProject.Models;
using System.Collections.Generic;

namespace GraphQLProject.Interfaces
{
    public interface IReservation
    {
        List<Reservation> GetReservations();
        Reservation AddReservation(Reservation reservation);
    }
}
