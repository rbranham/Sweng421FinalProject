﻿using System;
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
        public String name; 
        public List<QuestionIF> subQuestions = new List<QuestionIF>();


        public void createQuiz()
        {
            //this.name = "Compound Questions";  //Should change to be and input

            //using (TrueFalseCreation p = new TrueFalseCreation()) //Launch creation interface dialog
            //{
            //    if (p.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        this.subQuestions = p.subQuestions; //set generated question list to internal list
            //    }

            //}

        }

        public ResultsIF generateAnswerKey()
        {
            throw new NotImplementedException();
        }

        public string getName()
        {
            return name; ;
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

        public List<QuestionIF> getSubQuestions()
        {
            return subQuestions; 
        }
    }

    public class MultipleChoiceQuestion : QuestionIF
    {
        public String correctAnswer;
        public String[] answer = new string[4];
        public String questionText;
        //Need to call this to populate data
        public void createQuiz()
        {

            using (MultipleChoiceCreation p = new MultipleChoiceCreation())
            {
                if (p.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
                this.correctAnswer = p.correctAnswer;
                this.answer = p.answers;
                this.questionText = p.questionText;
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
    public class TrueFalseQuestion : QuestionIF
    {
        public Boolean trueFalse;
        public String questionText;
        //Need to call this to populate data
        public void createQuiz()
        {
            using (TrueFalseCreation p = new TrueFalseCreation())
            {
                if (p.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
                this.trueFalse = p.trueFalse;
                this.questionText = p.questionText;
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
