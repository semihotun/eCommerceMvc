﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class ApiGenerateAllowAnonymous : Attribute
    {
        public ApiGenerateAllowAnonymous()
        {
        }
    }
}