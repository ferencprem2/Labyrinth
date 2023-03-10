using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Player
    {
        private Coordinate _position;
        public Coordinate Coordinate => _position;

        private ConsoleColor _color;
        public ConsoleColor Color => _color;

        private int _steps;
        public int Steps => _steps;

        private int _remainingSteps;
        public int RemainingSteps => _remainingSteps;

        private int _treasure;
        public int Treasure => _treasure;

        private bool _canMove;
        public bool CanMove => _canMove;

        public Player()
        {
            _position = new Coordinate(0, 0);
            _color = ConsoleColor.Green;
            _steps = 0;
            _remainingSteps = int.MaxValue;
            _treasure = 0;
            _canMove = true;
        }
        public Player(Coordinate position, int remainingSteps)
        {
            _position = position;
            _color = ConsoleColor.Green;

            _treasure = 0;

            _canMove = true;
            _steps = 0;
            _remainingSteps = remainingSteps;
        }
        public Player(Coordinate position, ConsoleColor color, int remainingSteps)
        {
            _position = position;
            _color = color;

            _treasure = 0;

            _canMove = true;
            _steps = 0;
            _remainingSteps = remainingSteps;
        }


        public void Step(Coordinate coordinate)
        {
            if (!_canMove) throw new OutOfStepsException();
            _position = coordinate;
            _steps++;
            _remainingSteps--;
            if (_remainingSteps <= 0) _canMove = false;
        }
        public void SetRemainingSteps(int remainingSteps)
        {
            _remainingSteps = remainingSteps;
        }
        public void SetColor(ConsoleColor consoleColor)
        {
            _color = consoleColor;
        }
        public void AddTreasure()
        {
            _treasure++;
        }
    }
}
