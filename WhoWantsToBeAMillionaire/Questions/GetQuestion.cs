using System.Collections.Generic;
using System.Linq;

namespace WhoWantsToBeAMillionaire.Questions
{
    public class GetQuestion
    {
        public static Question GetEasyQuestion(int questionNumber)
        {
            List<Question> questions = new List<Question>();

            Question question1 = new Question();
            question1.Difficulty = Difficulty.Easy;
            question1.QuestionBody = "Which is the capital of Bulgaria?";
            question1.Answer = "Sofia";
            question1.WrongAnswers.AddRange(new List<string>() { "Paris", "London", "Berlin" });

            Question question2 = new Question();
            question2.Difficulty = Difficulty.Easy;
            question2.QuestionBody = @"Which colour is used as a term to describe an illegal market in
            rare goods?";
            question2.Answer = "Black";
            question2.WrongAnswers.AddRange(new List<string>() { "Blue", "Red", "White" });

            Question question3 = new Question();
            question3.Difficulty = Difficulty.Easy;
            question3.QuestionBody = "Which character was first played by Arnold Schwarzenegger in a 1984 film?";
            question3.Answer = "Terminator";
            question3.WrongAnswers.AddRange(new List<string>() { "Demonstrator", "Instigator", "Investigator" });

            Question question4 = new Question();
            question4.Difficulty = Difficulty.Easy;
            question4.QuestionBody = "Which of these would a film actor like to receive?";
            question4.Answer = "Oscar";
            question4.WrongAnswers.AddRange(new List<string>() { "Oliver", "Oliphant", "Osbert" });

            Question question5 = new Question();
            question5.Difficulty = Difficulty.Easy;
            question5.QuestionBody = @"In which country would you expect to be greeted with the word 'bonjour'?";
            question5.Answer = "France";
            question5.WrongAnswers.AddRange(new List<string>() { "Italy", "Spain", "Wales" });

            questions.Add(question1);
            questions.Add(question2);
            questions.Add(question3);
            questions.Add(question4);
            questions.Add(question5);

            return questions.ElementAt(questionNumber);
        }

        public Question GetMediumQuestion(int questionNumber)
        {
            List<Question> questions = new List<Question>();

            Question question6 = new Question();
            question6.Difficulty = Difficulty.Medium;
            question6.QuestionBody = @"The West Country is famous for which alcoholic drink?";
            question6.Answer = "Cider";
            question6.WrongAnswers.AddRange(new List<string>() { "Wine", "Beer", "Whisky" });

            Question question7 = new Question();
            question7.Difficulty = Difficulty.Medium;
            question7.QuestionBody = @"Which metal lends its name to a US five-cent coin?";
            question7.Answer = "Nickel";
            question7.WrongAnswers.AddRange(new List<string>() { "Iron", "Zinc", "Tin" });

            Question question8 = new Question();
            question8.Difficulty = Difficulty.Medium;
            question8.QuestionBody = @"What nationality is the film star Sean Connery?";
            question8.Answer = "Scottish";
            question8.WrongAnswers.AddRange(new List<string>() { "Irish", "English", "Welsh" });

            Question question9 = new Question();
            question9.Difficulty = Difficulty.Medium;
            question9.QuestionBody = @"In which film must a bus keep travelling at 50 miles per hour so that it does not explode?";
            question9.Answer = "Speed";
            question9.WrongAnswers.AddRange(new List<string>() { "Velocity", "Tempo", "Thrust" });

            Question question10 = new Question();
            question10.Difficulty = Difficulty.Medium;
            question10.QuestionBody = @"According to the saying, which of these is 'a dish best served cold'?";
            question10.Answer = "Revenge";
            question10.WrongAnswers.AddRange(new List<string>() { "Cottage pie", "Custard", "Stew" });

            questions.Add(question6);
            questions.Add(question7);
            questions.Add(question8);
            questions.Add(question9);
            questions.Add(question10);

            return questions.ElementAt(questionNumber);
        }

        public Question GetHardQuestion(int questionNumber)
        {
            List<Question> questions = new List<Question>();

            Question question11 = new Question();
            question11.Difficulty = Difficulty.Hard;
            question11.QuestionBody = @"'Wonderwall Music' and 'Electronic Sound' were solo albums by which Beatle?";
            question11.Answer = "George";
            question11.WrongAnswers.AddRange(new List<string>() { "John", "Paul", "Ringo" });

            Question question12 = new Question();
            question12.Difficulty = Difficulty.Hard;
            question12.QuestionBody = @"In Greek mythology, which bird was given the hundred eyes of Argus after his death?";
            question12.Answer = "Peacock";
            question12.WrongAnswers.AddRange(new List<string>() { "Eagle", "Phoenix", "Kingfisher" });

            Question question13 = new Question();
            question13.Difficulty = Difficulty.Hard;
            question13.QuestionBody = @"Who created the character Huckleberry Finn?";
            question13.Answer = "Mark Twain";
            question13.WrongAnswers.AddRange(new List<string>() { "Henry James", "Jack London", "Jonathan Swift" });

            Question question14 = new Question();
            question14.Difficulty = Difficulty.Hard;
            question14.QuestionBody = @"Which of these would be given an ASA rating?";
            question14.Answer = "Photographic film";
            question14.WrongAnswers.AddRange(new List<string>() { "Chess player", "Earthquake", "Meteorite" });

            Question question15 = new Question();
            question15.Difficulty = Difficulty.Hard;
            question15.QuestionBody = @"From which part of a plant is liquorice obtained?";
            question15.Answer = "Root";
            question15.WrongAnswers.AddRange(new List<string>() { "Leaf", "Stem", "Sap" });

            questions.Add(question11);
            questions.Add(question12);
            questions.Add(question13);
            questions.Add(question14);
            questions.Add(question15);

            return questions.ElementAt(questionNumber);
        }
    }
}