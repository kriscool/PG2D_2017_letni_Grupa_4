using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game4.Components
{
    class Animation : Component
    {
        private State _currentState;
        public Direction _curentDirection;
        private double _counter;
        private int _animationIndex;
        private int _widght;
        private int _height;

        public override ComponentType ComponentType
        {
            get
            {
                return ComponentType.Animation;
            }
        }

        public Rectangle TextureRectangle { get; private set;}



        public Animation(int widght, int height)
        {
            _widght = widght;
            _height = height;
            _counter = 0;
            _animationIndex = 0;
            _currentState = State.Standing;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            //throw new NotImplementedException();
        }

        public override void Update(double gameTime)
        {
            switch(_currentState)
            {
                case State.Walking:
                    _counter += gameTime;
                    if(_counter > 500)
                    {
                        ChangeState();
                        _counter = 0;

                    }
                    break;
            }
        }

        private void ChangeState()
        {
            switch(_curentDirection)
            {
                case Direction.Right:
                    TextureRectangle = new Rectangle(_widght * _animationIndex, _height, _widght, _height);
                    break;
                case Direction.Down:
                    TextureRectangle = new Rectangle(_widght * _animationIndex, 0, _widght, _height);
                    break;
                case Direction.Up:
                    TextureRectangle = new Rectangle(_widght * _animationIndex, _height * 2, _widght, _height);
                    break;
                case Direction.Left:
                    TextureRectangle = new Rectangle(_widght * _animationIndex, _height * 3, _widght, _height);
                    break;
            }
            _animationIndex = _animationIndex == 0 ? 1 : 0;
            _currentState = State.Standing;
        }
        public void ResetCounter(State state, Direction direction)
        {
            if(_curentDirection != direction)
            {
                _counter = 1000;
                _animationIndex = 0;
            }
            _currentState = state;
            _curentDirection = direction;
        }
    }
}
