using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sweng421FinalProject
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
    public interface QuizIF
    {

    }
    public interface QuizTypeIF
    {

    }
    public interface ResultsIF
    {
        public float getScore()
        {
            return 0;
        }
        public void seeResults()
        {

        }
    }
    public class QuizCompositie : QuizIF
    {
        List<QuizIF> questions = new List<QuizIF>();
        QuizTypeIF type;
        ResultsIF result;
        public QuizIF getQuestion(int index)
        {
            return questions[index]; //place holder
        }
        public ResultsIF gradeQuiz()
        {
            return result;
        }
    }
    public class StandardResults : ResultsIF
    {
        public float Score;

    }
    public abstract class AdvancedResultsAC : ResultsIF
    {
        public ResultsIF standardScore;

    }
    public class FeedbackResults : AdvancedResultsAC
    {
        public float Score;
        public String feedback = "";

    }
    public class QuizFactory
    {
        public QuizIF createQuiz(QuizIF qtype)
        {
            return qtype;
        }
    }
    public class Weekly : QuizTypeIF
    {

    }
    public class MidTerm : QuizTypeIF
    {

    }
    public class Exam : QuizTypeIF
    {

    }
    public class FIB_Q : QuizIF
    {

    }
    public class SA_Q : QuizIF
    {

    }
    public class MC_Q : QuizIF
    {

    }
}
