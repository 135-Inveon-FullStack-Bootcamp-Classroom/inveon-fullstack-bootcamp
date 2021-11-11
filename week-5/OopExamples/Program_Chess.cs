using System;

namespace OopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();

            var at = new At();

            at.Move(board.A3);

            Console.Write(board.A1.Color.ToString());
        }

        class At : IPiece
        {
            public Color Color { get; set; }
            public MoveType MoveType { get; set; }
            void Move(Coordinate coordinate)
            {

                // L şeklinde git
                throw new NotImplementedException();
            }
        }

        class Fil : IPiece
        {
            public Color Color { get; set; }
        }

        class Piyon : IPiece, IFirstMovable, IOneSquareMovable
        {
            public Color Color { get; set; }
            public MoveType MoveType { get; set; }
            public Coordinate Coordinate { get; set; }
            public void Move(Coordinate coordinate)
            {

                if (IsPlayedFirstMove == false)
                {
                    IsPlayedFirstMove = true;
                }
                throw new NotImplementedException();
            }

            public bool IsPlayedFirstMove { get; set; }
        }

        interface IPiece
        {
            Color Color { get; set; }
            MoveType MoveType { get; set; }
            Coordinate Coordinate { get; set; }

            virtual void Move(Coordinate coordinate)
            {
                // 1 kare ileri git
                this.Coordinate = coordinate;
            }
        }

        interface IFirstMovable
        {
            Boolean IsPlayedFirstMove { get; set; }
        }

        interface IOneSquareMovable
        {

        }

        class Board
        {
            public Coordinate A1 => new Coordinate("A", 1);
            public Coordinate A2 => new Coordinate("A", 2);
            public Coordinate A3 => new Coordinate("A", 3);
        }

        class Coordinate
        {
            private string _x;
            private int _y;

            public Coordinate(string x, int y)
            {
                X = x;
                Y = y;
            }

            public string X { get; set; }
            public int Y { get; set; }

            public Color Color
            {
                get
                {
                    if (X == "A" && Y == 1) return Color.Black;
                    if (X == "A" && Y == 2) return Color.White;

                    else return Color.White;
                }
            }
        }

        public enum Color
        {
            White,
            Black
        }

        internal enum MoveType
        {
            Duz,
            Capraz,
            DuzIleri,
            L,
            Rok
        }

    }

}
