using exam.Answers;
using exam.exam;
using exam.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.exams
{
    internal class ParticalExam : Exam
    {

        public ParticalExam(int timeoeexam, int numberofquestions) : base(timeoeexam, numberofquestions) 
        {
            questions = new Question[numberofquestions];

        }
        public ParticalExam():base(){}
       
        public Question[] Addquestions()
        {
            for (int i = 0; i < NumberOfQuestions; i++)
            {

              
                    questions[i] = new McqQuestion();
                    questions[i].HeadofQuestion = "MCQ Question";
                    Console.WriteLine("Enter the body of question:");
                    questions[i].BodyOfQuestion = Console.ReadLine();
                    Console.WriteLine("Enter the marks of the question:");
                    questions[i].Mark = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the number of choices:");
                    int choicesCount = int.Parse(Console.ReadLine());
                    questions[i].ListOfAnswers = new answers[choicesCount];
                    for (int j = 0; j < choicesCount; j++)
                    {
                        Console.WriteLine($"Enter choice {j + 1}:");
                        questions[i].ListOfAnswers[j] = new answers(j + 1, Console.ReadLine());
                    }
                    Console.WriteLine("Enter the right answer id:");
                    questions[i].RightAnswer = int.Parse(Console.ReadLine());
                
            }
            return questions;

        }
    }
}
