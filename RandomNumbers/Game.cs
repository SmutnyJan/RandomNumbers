using System;
using System.Collections.Generic;
using System.Text;

namespace RandomNumbers
{
    class Game
    {
        private Random _rand;
        private int _number;
        private int _bottomrange;
        private int _toprange;
        public int count { get; private set; }

        public Game(int bottomrange, int toprange)
        {
            _rand = new Random();
            _bottomrange = bottomrange;
            _toprange = toprange;
            _number = _rand.Next(_bottomrange, _toprange);
        }

        public GuessResult Guess(int number)
        {
            count++;
            if (number > _number) return GuessResult.IsGreater;
            if (number < _number) return GuessResult.IsLower;
            else return GuessResult.Success;
        }

        //public void Restart()
        //{
        //    Guess(25);
        //}
    }
}
