﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatSim
{
    public abstract class Plant : Leven
    {
        public Plant() { }
        public Plant(int verhoudingTicksJaren, String latijnseNaam, int levensduur, Bloeiwijze bloeiwijzePlant) : base(verhoudingTicksJaren, latijnseNaam, levensduur)
        {
            BloeiwijzePlant = bloeiwijzePlant;
        }

        public Bloeiwijze BloeiwijzePlant { get; set; }

    }
}
