﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.DAL
{
    public partial class Question
    {
        public Question()
        {
            ChoQues = new HashSet<ChoQue>();
            QuestionInstances = new HashSet<QuestionInstance>();
        }

        public int QueId { get; set; }
        public int QueType { get; set; }
        public string QueBody { get; set; }
        public double Grade { get; set; }
        public int CrsId { get; set; }

        public virtual Course Crs { get; set; }
        public virtual ICollection<ChoQue> ChoQues { get; set; }
        public virtual ICollection<QuestionInstance> QuestionInstances { get; set; }
    }
}
