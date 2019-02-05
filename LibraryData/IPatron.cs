﻿using LibraryData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
   public interface IPatron
    {
        Patron Get(int id);
        IEnumerable<Patron> GetAll();
        void Add(Patron newPatron);

        IEnumerable<CheckOuts> GetCheckOuts(int patronId);
        IEnumerable<Holds> GetHolds(int patronId);
        IEnumerable<CheckOutHistory> GetCheckoutHistory(int patronId);

    }
}