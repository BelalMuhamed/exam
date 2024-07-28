using exam.Answers;
using exam.exam;
using exam.Questions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.exams
{
    internal class FinalExam : Exam
    {

        public FinalExam(int timeofexam, int numberofquestions) : base(timeofexam, numberofquestions)
        {

            questions = new Question[numberofquestions];

        }
        public FinalExam() : base()
        {

        }
        
    


    public Question[] Addquestions()
        {
            for (int i = 0; i < NumberOfQuestions; i++)
            {
               
                int typeofquestion;
                do
                {
                    Console.WriteLine("Enter the type of question  1:(trueorfalse) 2:(MCQ) ");
                    int.TryParse(Console.ReadLine(), out typeofquestion);
                } while (typeofquestion != 1 && typeofquestion!=2);

                if(typeofquestion == 1 )
                {
                    questions[i] = new TrueOrFalseQuestion();
                    questions[i].HeadofQuestion = "True or False Question ";
                    Console.WriteLine("Enter the body of question");
                    questions[i].BodyOfQuestion = Console.ReadLine();
                    Console.WriteLine("Enter the marks of the question ");
                    questions[i].Mark = int.Parse(Console.ReadLine());
                    questions[i].ListOfAnswers = new answers[2];
                    questions[i].ListOfAnswers[0] = new answers(1, "true");
                    questions[i].ListOfAnswers[1] = new answers(2, "false");
                    Console.WriteLine("enter the right answer id 1= true 2 =false ");
                    questions[i].RightAnswer =int.Parse( Console.ReadLine());

                }
                else
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
            }
            return questions;

        }
        
    }
}
