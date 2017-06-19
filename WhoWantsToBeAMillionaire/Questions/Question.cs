using System.Collections.Generic;

namespace WhoWantsToBeAMillionaire.Questions
{
    public enum Difficulty
    {
        Easy,
        Medium,
        Hard
    };

    public class Question
    {
        public Question()
        {
            this.WrongAnswers = new List<string>();
        }

        public Difficulty Difficulty { get; set; }

        public string QuestionBody { get; set; }

        public string Answer { get; set; }

        public List<string> WrongAnswers { get; set; }
    }
}