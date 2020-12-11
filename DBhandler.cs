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

        public async void AddQuiz(Quiz q)
        {
            CollectionReference collection = db.Collection("Quizes"); //Parent level quiz collection
            Dictionary<string, object> quizData = new Dictionary<string, object>()
            {
                {"QuizName", q.getName() }
            };
            DocumentReference addedDocRef = await collection.AddAsync(quizData); //Adds document to database
            CollectionReference questionSubcollection = addedDocRef.Collection("Questions"); //Create sub collection

            foreach(QuestionIF question in q.getSubQuestions())
            {
                if (question is MultipleChoiceQuestion)
                {
                    AddMultipleChoice((MultipleChoiceQuestion)question, questionSubcollection);
                } //Would add more question types below
            }
        }

        public async void AddMultipleChoice(MultipleChoiceQuestion mc, CollectionReference quizRef)
        {
            Dictionary<string, object> questionData = new Dictionary<string, object>()
            {
                {"Questions", mc.questionText }
            };
            await quizRef.AddAsync(questionData); 

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

    }
}
