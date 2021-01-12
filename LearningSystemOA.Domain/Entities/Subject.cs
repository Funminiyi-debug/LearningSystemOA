using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSystemOA.Domain.Entities
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
