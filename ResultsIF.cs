using System;
using System.Collections.Generic;
using System.Text;

namespace Sweng421FinalProject
{
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
