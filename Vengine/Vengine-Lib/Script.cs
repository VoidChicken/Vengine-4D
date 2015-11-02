﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vengine_Lib
{
    public interface Script : Component
    {
        void Start();
        void Tick();
        void Unload();
        void FirstStart();
    }
}
