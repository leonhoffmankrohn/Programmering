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
        string password = "";
        int score = 0;
        public int Score { get { return score; } }
        public string Username { set; get; }
        public User(string _username, string _password)
        {
            Username = _username;
            password = Incrypt(_password);
            score = 0;
        }

        // Här lägger vi till i score
        public void AddScore(int correct) {score += correct;}
        // Här inkrypterar vi lösenordet, eller förskjuter vi bokstäverna till något oförståeligt
        private string Incrypt(string input)
        {
            string output = "";
            char[] alphabeth = "abcdefghijklmnopqrstuvwxyzåäöABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ1234567890".ToCharArray();
            char[] key = "GHIJKLMNOPQRSTUVWXYZÅÄÖ1234567890abcdefghijklmnopqrstuvwxyzåäöABCDEF".ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphabeth.Length; j++)
                {
                    if (input[i] == alphabeth[j]) output += key[j];
                }
            }
            return output;
        }

        // Här dekrypterar och avgör vi om lösnordet vi jämför med är rätt
        public bool ComparePasword(string comparingPassword)
        {
            char[] alphabeth = "abcdefghijklmnopqrstuvwxyzåäöABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ1234567890".ToCharArray();
            char[] key = "GHIJKLMNOPQRSTUVWXYZÅÄÖ1234567890abcdefghijklmnopqrstuvwxyzåäöABCDEF".ToCharArray();
            string decryptedPassword = "";
            for (int i = 0; i < password.Length; i++)
            {
                for (int j = 0; j < alphabeth.Length; j++)
                {
                    if (password[i] == key[j]) decryptedPassword += alphabeth[j];
                }
            }
            return (decryptedPassword == comparingPassword);
        }
    }
}
