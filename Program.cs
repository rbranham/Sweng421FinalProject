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

    }

    /*
    * Interface for questions 
    */
    public interface QuestionIF
    {

        public ResultsIF runQuiz();  //Run from student portal will call specific pop up and then return results
                                     //Should evenetualy return a results interface

        public void createQuiz();  //Run from teacher portal to create questions and quizes

        public ResultsIF generateAnswerKey(); //Run to generate a ResultsIF with the correct answer.   
                                              //we may want to generate on creation, not sure. 
    }


    public class Quiz : QuestionIF
    {
        List<QuestionIF> subQuestions;


        public void createQuiz()
        {
            throw new NotImplementedException();

            using (CompositeCreation p = new CompositeCreation()) //Launch creation interface dialog
            {
                if (p.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.subQuestions = p.subQuestions; //set generated question list to internal list
                }

            }

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
                results.addResult(subQuestions[i].runQuiz()); //Add each answer to list
            }

            return results; //Return the Results
        }
    }

    //Stubbed
    public class MultipleChoiceQuestion : QuestionIF
    {
        String questionText;

        String correctAnswer;


        //Need to call this to populate data
        public void createQuiz()
        {
            using (MultipleChoiceCreation p = new MultipleChoiceCreation())
            {
                if (p.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.questionText = p.question; //Get Question value

                    this.correctAnswer = p.correctAnswer; //Get correct answer value

                }

            }

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


    public interface ResultsIF
    {

        public void writeToFile(String fileString); //Writes the results to a file specified by string

    }

    public class ResultDecoratorForComposites : ResultsIF
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
