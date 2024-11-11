using System;

namespace DemoEncapsulation
{
    class Circle
    {
        private float _radius;

        public float Radius
        {
            get => _radius;
            set
            {
                if (value > 0)
                    _radius = value;
                else
                    throw new ArgumentException("Radius must be positive.");
            }
        }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public float GetArea() => (float)Math.PI * Radius * Radius;
    }

    class Rectangle
    {
        private float _length;
        private float _width;

        public float Length
        {
            get => _length;
            set
            {
                if (value > 0)
                    _length = value;
                else
                    throw new ArgumentException("Length must be positive.");
            }
        }

        public float Width
        {
            get => _width;
            set
            {
                if (value > 0)
                    _width = value;
                else
                    throw new ArgumentException("Width must be positive.");
            }
        }

        public Rectangle(float length, float width)
        {
            Length = length;
            Width = width;
        }

        public float GetArea() => Length * Width;
    }