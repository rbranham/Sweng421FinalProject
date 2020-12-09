using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sweng421FinalProject
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        /*
         * Interface for questions 
        */
        interface QuestionIF {

            public ResultsIF runQuiz();  //Run from student portal will call specific pop up and then return results
            //Should evenetualy return a results interface

            public void createQuiz();  //Run from teacher portal to create question
            //Maybe just run in constructor?

            public ResultsIF generateAnswerKey(); //Run to generate a ResultsIF with the correct answer.   
            //we may want to generate on creation, not sure. 
        }


        class Quiz : QuestionIF
        {
            List<QuestionIF> subQuestions;
            
            

            public void createQuiz()
            {
                throw new NotImplementedException();

                //Launch creation interface dialog
                //returns a list of subQuestions
                //set returned list to internal list

            }

            public ResultsIF generateAnswerKey()
            {
                throw new NotImplementedException();
            }

            public ResultsIF runQuiz()
            {
                ResultDecoratorForComposites results = new ResultDecoratorForComposites();

                //Loop through each question calling and returning
                for (int i = 0; i < subQuestions.Count(); i++)
                {
                    results.addResult( subQuestions[i].runQuiz()); //Add each answer to list
                }

                return results; //Return the Results
            }
        }

        //Stubbed
        class MultipleChoiceQuestion : QuestionIF
        {
            public void createQuiz()
            {
                throw new NotImplementedException();
            }

            public ResultsIF generateAnswerKey()
            {
                throw new NotImplementedException();
            }

            public ResultsIF runQuiz()
            {
                throw new NotImplementedException();
            }
        }


        interface ResultsIF {

            public void writeToFile(String fileString); //Writes the results to a file specified by string

        }

        class ResultDecoratorForComposites : ResultsIF
        {
            List<ResultsIF> rList;

            public ResultDecoratorForComposites()
            {
                rList = new List<ResultsIF>(); //Init
            }

            public void writeToFile(string fileString)
            {
                throw new NotImplementedException();
                //Open file
                //loop through the results list
                    //Call the write function for each element in list
            }

           public void addResult(ResultsIF r)
            {
                rList.Add(r);  //Add to list
            }

        }






    }
 
}
