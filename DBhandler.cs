using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Sweng421FinalProject
{
    //Class is set up as a singleton just for easier data persitance in testing database. Would not be singleton with real database
    class DBhandler
    {
        //List<String> teachID = new List<String> { "12345", "23456", "34567", "45678", "56789", "67890" };
        //List<String> studentID = new List<String> { "9876", "8765", "7654", "6543", "5432", "4321" };

        String dbFolderString = @"..\..\..\DatabaseFolder\" ;

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


        public List<String> getTeacherAccounts() {
            List<String> t = new List<String>();

            Debug.WriteLine("Accessing Teacher Accounts"); 

            foreach (String line in File.ReadLines(dbFolderString + "teacher_accounts.txt", Encoding.UTF8))
            {
                //add lines to list view
                Debug.WriteLine("Added Teacher Account: " + line);
                t.Add(line);
            }

            return t;

        }  //With real database would make sql call here instead

        public List<String> getstudentAccounts() {
            List<String> s = new List<String>();

            Debug.WriteLine("Accessing Student Accounts");

            foreach (String line in File.ReadLines(dbFolderString + "student_accounts.txt", Encoding.UTF8))
            {
                //add lines to list view
                Debug.WriteLine("Added Student Account: " + line);
                s.Add(line);
            }

            return s;
        }  


    }
}
