using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HoffQuiz
{
    class User
    {
        public List<int> Highscore = new List<int>();
        public string Username { set; get; }
        public User(string _username)
        {
            Username = _username;
        }

        // Här lägger vi till i Highscore
        public void AddScore(int correct, int quiz) 
        {
            if (Highscore.Count < quiz+1)
            {
                for (int i = Highscore.Count; i < quiz+1; i++) Highscore.Add(new());
            }
            if (Highscore[quiz] < correct) Highscore[quiz] = correct;
        }
    }
}
