using System;
using System.Collections.Generic;
using System.Text;

namespace Sweng421FinalProject
{
    //Class is set up as a singleton just for easier data persitance in testing database. Would not be singleton with real database
    class DBhandler
    {
        List<String> teachID = new List<String> { "12345", "23456", "34567", "45678", "56789", "67890" };
        List<String> studentID = new List<String> { "9876", "8765", "7654", "6543", "5432", "4321" };

        private static DBhandler INSTANCE = null; 

        private DBhandler()
        {

        }

        
        public static DBhandler getInstance()
        {
            if (INSTANCE == null)  //Create handler if doesn't exist
            {
                INSTANCE = new DBhandler(); 
            }

            return INSTANCE; 
        }


        public List<String> getTeacherAccounts() { return teachID;  }  //With real database would make sql call here
        public List<String> getstudentAccounts() { return teachID; }  


    }
}
