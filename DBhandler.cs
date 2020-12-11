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

            List<QuestionIF> qList = q.getSubQuestions();

            Debug.WriteLine("Adding quiz with: " + qList.Count + " Questions");

            for(int i = 0; i < qList.Count; i++) //Debug only to see if different quizes. 
            {
                Debug.WriteLine("Question " + i + " is: " + qList[i].getName());
            }

            foreach(QuestionIF question in qList)
            {
                if (question is MultipleChoiceQuestion)
                {
                    Debug.WriteLine("from addquiz, Sending MC Question: " + question.getName());

                    AddMultipleChoice((MultipleChoiceQuestion)question, questionSubcollection);
                } //Would add more question types below
                else
                {
                    throw new NotSupportedException(); 
                }
            }
        }

        public async void AddMultipleChoice(MultipleChoiceQuestion mc, CollectionReference quizRef)
        {

            Debug.WriteLine("Entering MC Question : " + mc.questionText);

            Dictionary<string, object> questionData = new Dictionary<string, object>()
            {
                {"Type", "MC" },   
                {"Question", mc.questionText },
                {"AnswerOne", mc.answers[0] },
                {"AnswerTwo", mc.answers[1] },
                {"AnswerThree", mc.answers[2] },
                {"AnswerFour", mc.answers[3] },
                {"ActualAnswer", mc.correctAnswer }
            };
            await quizRef.AddAsync(questionData); 

        }

        public async Task<List<String>> getAllQuizzes()
        {
            List<String> quizList = new List<String>();

            CollectionReference collection = db.Collection("Quizes"); //Parent level quiz collection
            Query query = collection; //sets parameters to Get all quiz documents
            QuerySnapshot snap = await query.GetSnapshotAsync();  //Get the documents 

            foreach (DocumentSnapshot quizSnap in snap.Documents)
            {
                quizList.Add(quizSnap.GetValue<String>("Quizname"));
            }

            return quizList;
        }
        
        public async Task<Quiz> getQuiz(String name)
        {
            Quiz q = new Quiz();  //Create the quiz to return

            //Logic to get the snapshot of the quizes documents
            CollectionReference collection = db.Collection("Quizes"); //Parent level quiz collection
            Query query = collection.WhereEqualTo("QuizName", name); //sets parameters to Get all quizes with the same name
            QuerySnapshot snap = await query.GetSnapshotAsync();  //Get the documents 
            DocumentSnapshot docSnap = snap[0]; //Get first document in the snap shot

            q.name = docSnap.GetValue<String>("QuizName"); // //Gets the quiz name

            //Get subcolleciton
            CollectionReference questionCollection = docSnap.Reference.Collection("Questions");  //Gets the sub collection
            Query questionQuery = questionCollection;  //Create query
            QuerySnapshot questionQuerySnap = await questionQuery.GetSnapshotAsync();  //Run query. 

            List<QuestionIF> questionList = new List<QuestionIF>(); 
            foreach (DocumentSnapshot questionSnap in questionQuerySnap.Documents)
            {
                QuestionIF nextQ; 
                //Runs for each quiz within
                string type = questionSnap.GetValue<String>("Type"); 
                if(type == "MC")
                {
                    nextQ = parseMCQuestion(questionSnap); //Call get for MC assign to next Q
                } else
                {
                    throw new NotSupportedException(); 
                }

                questionList.Add(nextQ);
            }

            q.subQuestions = questionList;  //set Question list

            return q;

        } 

        private MultipleChoiceQuestion parseMCQuestion(DocumentSnapshot qSnap)
        {
            MultipleChoiceQuestion mc = new MultipleChoiceQuestion();
            mc.questionText = qSnap.GetValue<String>("Question");
            mc.answers[0] = qSnap.GetValue<String>("AnswerOne");
            mc.answers[0] = qSnap.GetValue<String>("AnswerOne");
            mc.answers[0] = qSnap.GetValue<String>("AnswerOne");
            mc.answers[0] = qSnap.GetValue<String>("AnswerOne");
            mc.correctAnswer = qSnap.GetValue<String>("ActualAnswer");

            return mc; 
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
