using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblem
{
    public class Rover : IRover
    {
        private PositionBase _position { get; set; }

        PositionBase _plateauMarginPosition { get; set; }
        private Direction _direction { get; set; }

        public Rover(PositionBase startPosition, PositionBase plateauMarginPosition, Direction direction)
        {
            _position = startPosition;
            _direction = direction;
            _plateauMarginPosition = plateauMarginPosition;
        }

        public string GetLastPosition()
        {
            return ($"{_position.X} {_position.Y} {_direction.ToString()}"); ;
        }
        public void RotateRight()
        {
            _direction = (Direction)((int)(_direction + 1) % 4);
        }

        public void RotateLeft()
        {
            _direction = (Direction)((int)(_direction + 3) % 4);
        }

        public void MoveForward()
        {
            switch (_direction)
            {
                case Direction.N:
                    _position.Y += 1;
                    break;
                case Direction.S:
                    _position.Y -= 1;
                    break;
                case Direction.E:
                    _position.X += 1;
                    break;
                case Direction.W:
                    _position.X -= 1;
                    break;
                default:
                    break;
            }
            ControlPlatoeuMargin();
        }

        private void ControlPlatoeuMargin()
        {
            if (_position.X < 0 || _position.X > _plateauMarginPosition.X || _position.Y < 0 || _position.Y > _plateauMarginPosition.Y)
            {
                throw new Exception(string.Format(ErrorConstants.PlateaurCoordinatesOutOfBounds, _plateauMarginPosition.X, _plateauMarginPosition.Y));
            }
        }

    }
}
