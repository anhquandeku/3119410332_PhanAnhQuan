﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMent.Services
{
    public interface ITaxService
    {
        decimal TaxAmount(decimal totalAmount);
    }
}
