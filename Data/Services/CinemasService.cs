﻿using Movie_eTickets.Data.Base;
using Movie_eTickets.Models;

namespace Movie_eTickets.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context) {}
    }
}
