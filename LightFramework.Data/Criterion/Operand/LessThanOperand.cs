﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightFramework.Data
{
    public class LessThanOperand : Operand
    {
        private string _columnName;
        private object _columnValue;

        public LessThanOperand(string columnName, object columnValue)
        {
            this._columnName = columnName;
            this._columnValue = columnValue;
        }

        protected override string ToExpression()
        {
            return string.Format("{0} < {1} ", this._columnName, this._columnValue);
        }
    }
}
