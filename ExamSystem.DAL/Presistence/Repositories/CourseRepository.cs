﻿using ExamSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.DAL
{
    class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(ExamContext context)
            : base(context)
        {
        }
        public ExamContext ExamContext
        {
            get { return Context as ExamContext; }
        }
    }
}
