using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweng421FinalProject
{
    /*
     * Interface for questions 
     */
    public interface QuestionIF
    {

        public ResultsIF runQuiz();  //Run from student portal will call specific pop up and then return results
                                     //Should evenetualy return a results interface

        public void createQuiz();  //Run from teacher portal to create questions and quizzes

        public ResultsIF generateAnswerKey(); //Run to generate a ResultsIF with the correct answer.   
                                              //we may want to generate on creation, not sure. 

        public String getName(); //Used to get name string
    }


    public class Quiz : QuestionIF
    {
        List<QuestionIF> subQuestions;


        public void createQuiz()
        {

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

        public string getName()
        {
            return "Compound Questions";
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
                    this.correctAnswer = p.correct; //Get correct answer value
                }

            }

        }

        public ResultsIF generateAnswerKey()
        {
            throw new NotImplementedException();
        }

        public string getName()
        {
            return questionText; 
        }

        public ResultsIF runQuiz()
        {
            throw new NotImplementedException();
        }
    }


}
