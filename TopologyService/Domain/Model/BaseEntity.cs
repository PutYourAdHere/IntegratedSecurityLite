using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.CrossCutting.Model
{
    public abstract class BaseEntity
    {
        [Key, Required]
        public Guid Id { get; set; }

        public DateTime? UpdatedAt { get; set; }
        
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}

