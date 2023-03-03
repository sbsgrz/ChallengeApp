﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Emploee
    {
        static int emploeeCount = 0;
        private string firstName;
        private string lastName; 
        private uint age;

        private List<int> score = new List<int>();

        public int result => this.score.Sum();

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName;} set { lastName = value; } }
        public uint Age { get { return age; } set { age = value; } }    

         
        public Emploee()
        { 
            firstName= string.Empty;
            lastName= string.Empty;
            age= 0;
            Emploee.emploeeCount++;
        }

        public Emploee(string firstName, string lastName, uint age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            Emploee.emploeeCount++;
        }

        public bool AddScore(int score)
        {
            if (score < 0)
            {
                return false;
            }
            else
            {
                this.score.Add(score);
                return true;
            }
        }

        public bool RemoveScore(int score) 
        {
            if (score <= 0) 
            { 
                this.score.Add(score);
                return true;
            }
            else if(score > 0)
            {
                score = -score;
                this.score.Add(score);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
