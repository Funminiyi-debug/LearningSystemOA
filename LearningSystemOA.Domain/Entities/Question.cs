using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LearningSystemOA.Domain.Entities
{
   public  class Question : BaseEntity
    {
        [Required]
        public string  Description { get; set; }
        
        public Subject Subject { get; set; }

        [Required]
        public int SubjectId { get; set; }

        public ICollection<Alternative> Alternatives { get; set; }
    }
}
