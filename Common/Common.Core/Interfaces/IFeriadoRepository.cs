﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.Interfaces
{
    public interface IFeriadoRepository
    {
        bool EsFeriado(DateTime fecha);
    }
}
