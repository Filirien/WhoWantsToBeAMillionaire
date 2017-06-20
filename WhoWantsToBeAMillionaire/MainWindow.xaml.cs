using System;
using System.Linq;
using System.Windows;
using WhoWantsToBeAMillionaire.Helpers;
using WhoWantsToBeAMillionaire.Questions;

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
            int counterRounds = 0;
            var Question = GetQuestion.GetEasyQuestion(0);
            AnswerOne.Content = Question.Answer;
            var wrongAnswr = Question.WrongAnswers.Take(3);
            AnswerTwo.Content = wrongAnswr.ElementAt(0);
            AnswerThree.Content = wrongAnswr.ElementAt(1);
            AnswerFour.Content = wrongAnswr.ElementAt(2);
        }

     

        private void AnswerOne_OnClick(object sender, RoutedEventArgs e)
        {
         
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
           
        }

        private void JokerThree_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

 
    }
}