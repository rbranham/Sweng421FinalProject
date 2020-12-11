using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Sweng421FinalProject
{

    class DBhandler
    {
        private static DBhandler INSTANCE = null;
        FirestoreDb db; 
        public DBhandler()
        {
            db = FirestoreDb.Create("sweng421-finalproject"); //set up connection
        }

        
        public static DBhandler getInstance() //This doesn't have to be a singleton anymore with new database. 
        {
            if (INSTANCE == null) 
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
        /*
         * This DB list needs created, it will hold the quizzes that have been created
         */
        public async Task<List<String>> getQuiz()
        {
            List<String> q = new List<String>();
            //fire store way
            CollectionReference typesRef = db.Collection("quiz");
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
