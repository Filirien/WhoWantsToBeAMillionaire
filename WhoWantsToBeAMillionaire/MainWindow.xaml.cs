using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WhoWantsToBeAMillionaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }

<<<<<<< HEAD
        private void AnswerOne_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AnswerTwo_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AnswerThree_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AnswerFour_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void JokerOne_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void JokerTwo_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
=======
            asd();

            int counterRounds = 0;

            Questions.GetQuestion newQuestion = new Questions.GetQuestion();

            if (counterRounds < 5)
            {
                Questions.Question newEasyQuestion = newQuestion.GetEasyQuestion(counterRounds);
                string question = newEasyQuestion.QuestionBody.ToString();
                string WrongAnswersOne = newEasyQuestion.WrongAnswers.ToArray().ElementAt(0).ToString();
                string WrongAnswersTwo = newEasyQuestion.WrongAnswers.ToArray().ElementAt(1).ToString();
                string WrongAnswersThree = newEasyQuestion.WrongAnswers.ToArray().ElementAt(2).ToString();
                string answer = newEasyQuestion.Answer;
            }
            else if (counterRounds < 10 && counterRounds >= 5)
            {
                Questions.Question newMediumQuestion = newQuestion.GetMediumQuestion(counterRounds);
                string WrongAnswersOne = newMediumQuestion.WrongAnswers.ToArray().ElementAt(0).ToString();
                string WrongAnswersTwo = newMediumQuestion.WrongAnswers.ToArray().ElementAt(1).ToString();
                string WrongAnswersThree = newMediumQuestion.WrongAnswers.ToArray().ElementAt(2).ToString();
                string answer = newMediumQuestion.Answer;
            }
            else if (counterRounds < 15 && counterRounds >= 10)
            {
                Questions.Question newHardQuestion = newQuestion.GetHardQuestion(counterRounds);
                string WrongAnswersOne = newHardQuestion.WrongAnswers.ToArray().ElementAt(0).ToString();
                string WrongAnswersTwo = newHardQuestion.WrongAnswers.ToArray().ElementAt(1).ToString();
                string WrongAnswersThree = newHardQuestion.WrongAnswers.ToArray().ElementAt(2).ToString();
                string answer = newHardQuestion.Answer;
            }

            counterRounds++;
>>>>>>> origin/master
        }

        private void JokerThree_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
