﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightFramework.Data.MySQL
{
    public class IsNotNullOperand : Operand
    {
        private string _columnName;

        public IsNotNullOperand(string columnName)
        {
            this._columnName = columnName;
        }

        public override string ToString()
        {
            return string.Format("{0} Is Not Null", this._columnName);
        }
    }
}
