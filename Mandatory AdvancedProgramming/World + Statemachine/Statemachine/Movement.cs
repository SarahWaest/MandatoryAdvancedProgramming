using System;
using System.Collections.Generic;
using System.Text;
using Mandatory_AdvancedProgramming.Objects;

namespace Mandatory_AdvancedProgramming.World
{
    class Movement
    {
        private int _direction;
        private CheckForCollision _checkForCollision;

        private _directionEnum _directionName;

        public enum _directionEnum
        {
            North,
            South,
            East,
            West
        }

        public void changedirection(ConsoleKeyInfo keypress)
        {
            if (keypress.KeyChar == 'a')
            {
                turnLeft();
            }
            else if (keypress.KeyChar == 'd')
            {
                turnRight();
            }
        }

        public void turnLeft()
        {
            if (_direction == 0)
            {
                _direction = 360;
            }
            _direction += -90;
            ChangeDirectionName();
        }

        public void turnRight()
        {
            if (_direction == 360)
            {
                _direction = 0;
            }
            _direction += 90;
            ChangeDirectionName();
        }

        private void ChangeDirectionName()
        {
            if (_direction == 0 || _direction == 360)
            {
                _directionName = _directionEnum.North;
            }

            if (_direction == 90)
            {
                _directionName = _directionEnum.East;
            }

            if (_direction == 180)
            {
                _directionName = _directionEnum.South;
            }

            if (_direction == 270)
            {
                _directionName = _directionEnum.West;
            }
        }

        public _directionEnum DirectionName
        {
            get { return _directionName; }
            set { _directionName = value; }
        }
    }
}
