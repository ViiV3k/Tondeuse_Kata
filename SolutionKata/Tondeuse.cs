using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionKata
{
    internal class Tondeuse
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public char Orientation { get; private set; }

        public Tondeuse(int x, int y, char orientation)
        {
            X = x;
            Y = y;
            Orientation = orientation;
        }

        public void ExecuteInstructions(string instructions, int maxX, int maxY)
        {
            foreach (char instruction in instructions)
            {
                if (instruction == 'G')                
                    RotateLeft();
                
                else if (instruction == 'D')                
                    RotateRight();
                
                else if (instruction == 'A')                
                    MoveForward(maxX, maxY);
                
            }
        }

        private void RotateLeft()
        {
            switch (Orientation)
            {
                case 'N':
                    Orientation = 'W';
                    break;

                case 'E':
                    Orientation = 'N';
                    break;

                case 'S':
                    Orientation = 'E';
                    break;

                case 'W':
                    Orientation = 'S';
                    break;
            }
        }

        private void RotateRight()
        {
            switch (Orientation)
            {
                case 'N':
                    Orientation = 'E';
                    break;

                case 'E':
                    Orientation = 'S';
                    break;

                case 'S':
                    Orientation = 'W';
                    break;

                case 'W':
                    Orientation = 'N';
                    break;
            }
        }

        private void MoveForward(int maxX, int maxY)
        {
            switch (Orientation)
            {
                case 'N':
                    if (Y < maxY)                    
                        Y++;
                    
                    break;
                case 'E':
                    if (X < maxX)
                    
                        X++;
                    
                    break;
                case 'S':
                    if (Y > 0)                    
                        Y--;
                    
                    break;
                case 'W':
                    if (X > 0)                    
                        X--;
                    
                    break;
            }
        }
    }
}
