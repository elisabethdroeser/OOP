﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class NumbericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text field only. This fired an error!";
        }
    }
}
