using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.Answers
{
    internal class answers
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public answers(int id ,string answer) 
        {
            AnswerId= id;
            AnswerText= answer;
        }
        public answers()
        { }
    }
}
