using LearningSystemOA.Domain.Entities;
using LearningSystemOA.Repository.Data;
using LearningSystemOA.Repository.Implementations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSystemOA.Repository.Implementations.Repositories
{
   public class SubjectRepository :  Repository<Subject>, ISubjectRepository
    {
        public SubjectRepository( RepositoryContext repo) : base(repo)
        {

        }
    }
}
