﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neuzilla.SMSProvider.Core
{
    public interface ISMSApi<T> : IApi<T>
    {
        ISMSVendorContext Context { get; set; }
    }
}
