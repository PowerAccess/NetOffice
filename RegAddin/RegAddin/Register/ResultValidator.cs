﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegAddin.Register
{
    internal class ResultValidator
    {
        internal ResultValidator(int result)
        {
            Result = result;
        }

        internal int Result { get; private set; }

        internal void ThrowIfNeeded()
        {
            if (0 != Result)
                Throw();
        }

        private void Throw()
        {
            ResultCodes resultCode = (ResultCodes)Result;
            throw new RegisterException(resultCode.ToString());
        }
    }
}
