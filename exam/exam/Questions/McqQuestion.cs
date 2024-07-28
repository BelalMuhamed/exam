using exam.exam;
using exam.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.Questions
{
    internal class McqQuestion : Question
    {
        public McqQuestion( string headofquestion,string BodyOfQuestion, int Mark, int NumberOFAnswers) : base( headofquestion,BodyOfQuestion, Mark, 2)
        {
            
        }
        public McqQuestion(): base()
        {
            
        }
       
    }
}
