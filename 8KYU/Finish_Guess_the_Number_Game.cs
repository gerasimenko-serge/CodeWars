using System;

namespace Finish_Guess_the_Number_Game
{
    public class Guesser
    {
        private int number;
        private int lives;

        public Guesser(int number, int lives)
        {
            this.number = number;
            this.lives = lives;
        }

        public bool Guess(int n)
        {
            if (this.lives <= 0) throw new Exception("Oooops");
            var condition = (n == this.number);
            if (!condition) this.lives--;
            return condition;
        }
    }
}
