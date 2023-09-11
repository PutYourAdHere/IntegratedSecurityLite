using System;
using System.ComponentModel.DataAnnotations;

namespace TopologyApi.Model
{
    public abstract class BaseDto //: IValidatableObject 
    {

        [Key, Required]
        public Guid Id { get; set; }

        //public abstract IEnumerable<ValidationResult> Validate(ValidationContext validationContext);

    }
}
