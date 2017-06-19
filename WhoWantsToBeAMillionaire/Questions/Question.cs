using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Difficulty Difficulty { get; set; }
    }
}
