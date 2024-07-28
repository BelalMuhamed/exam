using exam.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.exam
{
     abstract class Question
    {
        public string HeadofQuestion { get; set; }
        public string BodyOfQuestion { get; set; }
        public int Mark { get; set; }
        public answers[] ListOfAnswers { get; set; }
        public int RightAnswer { get; set; }
        public int UserAnswer { get; set; }

        public Question(string headOfquestion,string BodyOfQuestion,int Mark,int NumberOFAnswers) 
        { 
            this.HeadofQuestion = headOfquestion;
            this.BodyOfQuestion = BodyOfQuestion;   
            this.Mark = Mark;
            this.ListOfAnswers = new answers[NumberOFAnswers]; 
        }
        public Question() {
            
        }
        public bool IsCorrect()
        {
            return UserAnswer == RightAnswer;
        }
    }
}
