﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightFramework.Data.MySQL
{
    public class IsNullOperand : DecoratorOperand
    {
        private string _columnName;

        public IsNullOperand(string columnName)
        {
            this._columnName = columnName;
        }

        public override string ToString()
        {
            return string.Format("{0} Is Null {1}", this._columnName,this._operand.ToString());
        }
    }
}
