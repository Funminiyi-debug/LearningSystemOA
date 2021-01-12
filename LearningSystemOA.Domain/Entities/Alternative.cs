using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LearningSystemOA.Domain.Entities
{
    public class Alternative : BaseEntity
    {
        [Required]
        public string Text { get; set; }

        public Boolean isCorrect { get; set; } = false;
    }
}
