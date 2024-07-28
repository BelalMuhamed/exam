using exam.exam;
using exam.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.Questions
{
    internal class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string headofquestion,string BodyOfQuestion, int Mark) : base(headofquestion,BodyOfQuestion, Mark, 2)
        {

        }
        public TrueOrFalseQuestion() :base()
        {
        
        }

    }
}
