﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sweng421FinalProject
{
    public class questionsFactory
    {
        public QuestionIF createQuestion(String s)
        {
            //logic for what question to create
            switch (s)
            {
                case "Composite":
                    return new Quiz();
                case "Multiple Choice":
                    return new MultipleChoiceQuestion();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
