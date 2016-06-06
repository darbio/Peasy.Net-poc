﻿using Peasy.Core;
using System;

namespace Peasy.Rules
{
    public class ValueRequiredRule : RuleBase
    {
        private string _errorMessage;
        private Func<bool> _validate;

        public ValueRequiredRule(long value, string fieldName)
        {
            _errorMessage = $"{fieldName} must be greater than 0";
            _validate = () => value > 0;
        }

        public ValueRequiredRule(decimal value, string fieldName)
        {
            _errorMessage = $"{fieldName} must be greater than 0";
            _validate = () => value > 0;
        }

        public ValueRequiredRule(int value, string fieldName)
        {
            _errorMessage = $"{fieldName} must be greater than 0";
            _validate = () => value > 0;
        }

        public ValueRequiredRule(string value, string fieldName)
        {
            _errorMessage = $"{fieldName} must be supplied";
            _validate = () => !string.IsNullOrWhiteSpace(value);
        }

        public ValueRequiredRule(Guid value, string fieldName)
        {
            _errorMessage = $"{fieldName} must be supplied";
            _validate = () => value != Guid.Empty;
        }

        protected override void OnValidate()
        {
            if (!_validate())
                Invalidate(_errorMessage);
        }
    }
}
