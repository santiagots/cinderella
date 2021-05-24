﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.Exceptions
{
    public class NegocioException: Exception
    {
        public NegocioException()
        {
        }

        public NegocioException(string message): base(message)
        {
        }

        public NegocioException(string message, Exception inner): base(message, inner)
        {
        }
    }
}
