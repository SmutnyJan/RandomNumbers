using System;
using System.Collections.Generic;
using System.Text;

namespace RandomNumbers
{
    class Game
    {
        private Random _rand;
        private int _number;

        public Game(int bottomrange, int toprange)
        {
            _range = range;
            _number = _rand.Next(bottomrange, toprange);
        }

        public GuessResult Guess(int number)
        {
            if (number > _number) return GuessResult.IsGreater;
            if (number < _number) return GuessResult.IsLower;
            else return GuessResult.Success;
        }

        public void Restart()
        {
            Guess(25);
        }
    }
}
