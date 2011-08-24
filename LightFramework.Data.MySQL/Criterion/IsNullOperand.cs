﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightFramework.Data.MySQL
{
    public class IsNullOperand : Operand
    {
        private string _columnName;

        public IsNullOperand(string columnName)
        {
            this._columnName = columnName;
        }

        public override string ToString()
        {
            return string.Format("{0} Is Null", this._columnName);
        }
    }
}
