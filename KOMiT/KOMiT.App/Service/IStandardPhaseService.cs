﻿using KOMiT.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.App.Service
{
    public  interface IStandardPhaseService
    {
        Task CreatePhase(StandardPhase standardPhase);
    }
}
