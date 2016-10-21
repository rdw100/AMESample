﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WIC.Framework.ValidationRules
{
    // base class for regex based validation rules.

    public class ValidateRegex : ValidationRule
    {
        protected string Pattern { get; set; }

        public ValidateRegex(string propertyName, string pattern)
            : base(propertyName)
        {
            Pattern = pattern;
        }

        public ValidateRegex(string propertyName, string errorMessage, string pattern)
            : this(propertyName, pattern)
        {
            Error = errorMessage;
        }

        public override bool Validate(ValidationObject validationObject)
        {
            return Regex.Match(GetPropertyValue(validationObject).ToString(), Pattern).Success;
        }
    }
}
