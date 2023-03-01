﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    class User
    {
        public static string GameName = "Diablo";

        private List<int> score = new List<int>();

        public string Login { get; private set; }

        public string Password { get; private set; }

        public int Result
        {
            get
            {
                return score.Sum();
            }
        }

        public User()
        {
            this.Login = "-";
            this.Password = "-";
        }

        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }

        public void AddScore(int score)
        {
            this.score.Add(score);
        }
    }
}
