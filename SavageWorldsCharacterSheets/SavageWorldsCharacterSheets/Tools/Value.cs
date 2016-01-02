﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SavageWorldsCharacterSheets.Tools
{
    /// <summary>
    /// Contains the die and modifier for any trait
    /// </summary>
    [Serializable]
    public class Value
    {
        public Dice DieType { get; set; }
        public int Modifier { get; set; }
    }
}