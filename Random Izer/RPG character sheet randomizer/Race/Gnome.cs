﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_character_sheet_randomizer.Race
{
    class Gnome
    {
        public static string getSubRace()
        {
            List<string> L = Vars.D5Core["Gnome"]
                            .Select(t => (string)t).ToList();

            int r = Rolling.RollD(Vars.findSize<string>(L))-1;
            return L[r];
        }
    }
}
