using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoWantsToBeAMillionaire.Questions;

namespace WhoWantsToBeAMillionaire.JokerFiftyFifty
{
    class Helper
    {
        private static Random rand = new Random();
        public static void FiftyFifty(Question question)
        {
            var remainQuestionIndex = rand.Next(0, 3);
            var wrongAnswers = question.WrongAnswers;
            for (int i = 0; i < wrongAnswers.Count; i++)
            {
                if (i != remainQuestionIndex)
                {
                    // тук трябва да скрием  отговора
                }
            }
        }
        public static void FriendsHelp(Question question, int rightAnswerChance = 75)
        {
            var roll = rand.Next(0, 101);
            if (roll < rightAnswerChance)
            {
                // тук някъде в текстово поле ще върнем верния отговор
            }
            else
            {
                var remainQuestionIndex = rand.Next(0, 3);
                // тук на произволен принцип ще въренем грешен отговор с горния индекс 
            }
        }
        public static void HelpFromViewers()
        {
            var remainPercnets = 100;
            var rightAnswerPercent = 50;
            var fristWrongAnswerPercent = rand.Next(0, remainPercnets - rightAnswerPercent);
            var secondWrongAnswerPercent = rand.Next(0, remainPercnets - fristWrongAnswerPercent);
            var thirdWrongAnswerPercent = rand.Next(0, remainPercnets - secondWrongAnswerPercent);
            // и тук трябва да се визуализира графика във форма
        }
    }
}
