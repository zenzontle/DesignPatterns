﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface ILogBridge
    {
        void CallLog(string textToLog);
        void CallLogError(string errorToLog);
    }
}
