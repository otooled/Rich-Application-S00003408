﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RACASem6.Models;

namespace RACASem6.DAL
{
    public interface ITourRepository : IDisposable
    {
        IQueryable<Trip> GetAllTrips();
        Trip GetTripById(int? id);
        Trip GetLegsByTripId(int? id);
        Trip AddTrip(Trip t);
        Leg AddLeg(Leg l);
        IQueryable<Guest> ListGuest();
        Guest AddGuest(Guest g);
        IQueryable<Leg> CheckTripViability(int id);

    }
}
