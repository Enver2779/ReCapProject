﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
   public interface IResult
    {
        bool Seccess { get; }
        string Message { get; }
        bool Success { get; set; }
    }
}
