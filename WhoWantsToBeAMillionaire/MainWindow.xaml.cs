using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WhoWantsToBeAMillionaire.Helpers;
using WhoWantsToBeAMillionaire.Questions;

namespace WhoWantsToBeAMillionaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counterRounds;

        public MainWindow()
        {
            InitializeComponent();
            CallEasyQuestions();
        }


        private void AnswerOne_OnClick(object sender, RoutedEventArgs e)
        {
            CheckForAnswer(AnswerOne);
        }


        private void AnswerTwo_OnClick(object sender, RoutedEventArgs e)
        {
            CheckForAnswer(AnswerTwo);
        }

        private void AnswerThree_OnClick(object sender, RoutedEventArgs e)
        {
            CheckForAnswer(AnswerThree);
        }

        private void AnswerFour_OnClick(object sender, RoutedEventArgs e)
        {
            CheckForAnswer(AnswerFour);
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

        private void CallEasyQuestions()
        {
            var Question = GetQuestion.GetEasyQuestion(counterRounds);
            QuestionToAsk.Text = Question.QuestionBody;
            var wrongAnswr = Question.WrongAnswers.Take(3);
            int random = DateTime.Now.Second;
            if (random%4==0)
            {
                AnswerOne.Content = Question.Answer;
                AnswerTwo.Content = wrongAnswr.ElementAt(0);
                AnswerThree.Content = wrongAnswr.ElementAt(1);
                AnswerFour.Content = wrongAnswr.ElementAt(2);
            }
            else if (random % 4 == 1)
            {
                AnswerOne.Content = wrongAnswr.ElementAt(0);
                AnswerTwo.Content = Question.Answer;
                AnswerThree.Content = wrongAnswr.ElementAt(1);
                AnswerFour.Content = wrongAnswr.ElementAt(2);
            }
            else if (random % 4 == 2)
            {
                AnswerOne.Content = wrongAnswr.ElementAt(0);
                AnswerTwo.Content = wrongAnswr.ElementAt(1);
                AnswerThree.Content = Question.Answer;
                AnswerFour.Content = wrongAnswr.ElementAt(2);
            }
            else
            {
                AnswerOne.Content = wrongAnswr.ElementAt(2);
                AnswerTwo.Content = wrongAnswr.ElementAt(0);
                AnswerThree.Content = wrongAnswr.ElementAt(1);
                AnswerFour.Content = Question.Answer;
            }
        }

        private void CallMediumQuestions()
        {
            var Question = GetQuestion.GetMediumQuestion(counterRounds - 5);
            QuestionToAsk.Text = Question.QuestionBody;
            var wrongAnswr = Question.WrongAnswers.Take(3);
            int random = DateTime.Now.Second;
            if (random % 4 == 0)
            {
                AnswerOne.Content = Question.Answer;
                AnswerTwo.Content = wrongAnswr.ElementAt(0);
                AnswerThree.Content = wrongAnswr.ElementAt(1);
                AnswerFour.Content = wrongAnswr.ElementAt(2);
            }
            else if (random % 4 == 1)
            {
                AnswerOne.Content = wrongAnswr.ElementAt(0);
                AnswerTwo.Content = Question.Answer;
                AnswerThree.Content = wrongAnswr.ElementAt(1);
                AnswerFour.Content = wrongAnswr.ElementAt(2);
            }
            else if (random % 4 == 2)
            {
                AnswerOne.Content = wrongAnswr.ElementAt(0);
                AnswerTwo.Content = wrongAnswr.ElementAt(1);
                AnswerThree.Content = Question.Answer;
                AnswerFour.Content = wrongAnswr.ElementAt(2);
            }
            else
            {
                AnswerOne.Content = wrongAnswr.ElementAt(2);
                AnswerTwo.Content = wrongAnswr.ElementAt(0);
                AnswerThree.Content = wrongAnswr.ElementAt(1);
                AnswerFour.Content = Question.Answer;
            }
        }

        private void CallHardQuestions()
        {
            var Question = GetQuestion.GetHardQuestion(counterRounds - 10);
            QuestionToAsk.Text = Question.QuestionBody;
            var wrongAnswr = Question.WrongAnswers.Take(3);
            int random = DateTime.Now.Second;
            if (random % 4 == 0)
            {
                AnswerOne.Content = Question.Answer;
                AnswerTwo.Content = wrongAnswr.ElementAt(0);
                AnswerThree.Content = wrongAnswr.ElementAt(1);
                AnswerFour.Content = wrongAnswr.ElementAt(2);
            }
            else if (random % 4 == 1)
            {
                AnswerOne.Content = wrongAnswr.ElementAt(0);
                AnswerTwo.Content = Question.Answer;
                AnswerThree.Content = wrongAnswr.ElementAt(1);
                AnswerFour.Content = wrongAnswr.ElementAt(2);
            }
            else if (random % 4 == 2)
            {
                AnswerOne.Content = wrongAnswr.ElementAt(0);
                AnswerTwo.Content = wrongAnswr.ElementAt(1);
                AnswerThree.Content = Question.Answer;
                AnswerFour.Content = wrongAnswr.ElementAt(2);
            }
            else
            {
                AnswerOne.Content = wrongAnswr.ElementAt(2);
                AnswerTwo.Content = wrongAnswr.ElementAt(0);
                AnswerThree.Content = wrongAnswr.ElementAt(1);
                AnswerFour.Content = Question.Answer;
            }
        }


        private void CheckForAnswer(Button Answer)
        {
            bool check ;
            if (counterRounds < 5)
            {
                check = Answer.Content == GetQuestion.GetEasyQuestion(counterRounds).Answer;
            }
            else if (counterRounds >= 5 && counterRounds < 10)
            {
                check = Answer.Content == GetQuestion.GetMediumQuestion(counterRounds-5).Answer;
            }
            else
            {
                check = Answer.Content == GetQuestion.GetHardQuestion(counterRounds-10).Answer;
            }
            if (check)
            {
                counterRounds++;
                if (counterRounds >= 5 && counterRounds < 10)
                {
                    CallMediumQuestions();
                }
                else if (counterRounds < 5)
                {
                    CallEasyQuestions();
                }
                else if (counterRounds >= 10 && counterRounds < 15)
                {
                    CallHardQuestions();
                }
                else
                {
                    MessageBox.Show("You won all the money there is, please spare us, Master");
                }
            }
            else
            {
                MessageBox.Show("WrongAnswer");
                counterRounds = 0;
                CallEasyQuestions();
            }
        }
    }
}