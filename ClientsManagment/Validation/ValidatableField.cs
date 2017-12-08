using System;
using System.Collections.Generic;
using System.Linq;

namespace ClientsManagment.Validation
{
    public class ValidatableField<T>
    {
        public T Value { get; set; }

        public IEnumerable<string> Errors { get; set; }

        public bool IsValid => !this.Errors.Any();

        public string ErrorsAsString => string.Join(Environment.NewLine, this.Errors);

        public ValidatableField()
        {
            this.Errors = new List<string>();
        }

        public ValidatableField(T value)
        {
            this.Errors = new List<string>();
            this.Value = value;

        }
    }
}
