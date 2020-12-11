using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Sweng421FinalProject
{
    //Class is set up as a singleton just for easier data persitance in testing database. Would not be singleton with real database
    class DBhandler
    {
        //List<String> teachID = new List<String> { "12345", "23456", "34567", "45678", "56789", "67890" };
        //List<String> studentID = new List<String> { "9876", "8765", "7654", "6543", "5432", "4321" };

        String dbFolderString = @"..\..\..\DatabaseFolder\" ;

        private static DBhandler INSTANCE = null;
        FirestoreDb db; 
        public DBhandler()
        {
            db = FirestoreDb.Create("sweng421-finalproject"); //set up connection
        }

        
        public static DBhandler getInstance()
        {
            if (INSTANCE == null)  //Create handler if doesn't exist
            {
                INSTANCE = new DBhandler(); 
            }

            return INSTANCE; 
        }

        public async Task<List<Teacher>> getTeacherAccounts()
        {
            List<Teacher> q = new List<Teacher>();
            //fire store way
            CollectionReference typesRef = db.Collection("teacherAccounts");
            QuerySnapshot snapshot = await typesRef.GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Dictionary<string, object> documentDictionary = document.ToDictionary();
                q.Add(new Teacher(
                    documentDictionary["Name"].ToString(), 
                    documentDictionary["Username"].ToString()
                    ));
            }

            return q;
        }

        public async Task<List<Student>> getStudentAccounts()
        {
            List<Student> q = new List<Student>();
            //fire store way
            CollectionReference typesRef = db.Collection("teacherAccounts");
            QuerySnapshot snapshot = await typesRef.GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Dictionary<string, object> documentDictionary = document.ToDictionary();
                q.Add(new Student(
                    documentDictionary["Name"].ToString(),
                    documentDictionary["Username"].ToString()
                    ));

                Debug.WriteLine("Added teacher with userName: " + documentDictionary["Username"].ToString());
            }

            return q;
        }

        //With a real database would make sql calls inside these methods instead of reading files

        /*
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

        }  

        public List<String> getStudentAccounts() {
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
        */

        public async Task<List<String>> getQuestionTypes()
        {

            List<String> q = new List<String>();
            //fire store way
            CollectionReference typesRef = db.Collection("quizTypes");
            QuerySnapshot snapshot = await typesRef.GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Dictionary<string, object> documentDictionary = document.ToDictionary();
                q.Add(documentDictionary["Name"].ToString());
            }

            return q;
            
        }

    }
}
