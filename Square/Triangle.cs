using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    public class Triangle: IGetSquare
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        private bool  check { get; set; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Сторона треугольника должна быть больше 0");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;


            ref double maxSide = ref sideA;
            ref double leg1 = ref sideB;
            ref double leg2 = ref sideC;
            if (maxSide < sideB)
            {
                maxSide = ref sideB;
                leg1 = ref sideA;
                leg2 = ref sideC;
            }

            if (maxSide < sideC)
            {
                maxSide = ref sideC;
                leg2 = ref sideB;
                leg1 = ref sideA;
            }

            if(maxSide > leg1 + leg2)
            {
                throw new ArgumentException("Сторона треугольника не должна превышать сумму двух других");
            }

            if (maxSide * maxSide == (leg1 * leg1 + leg2 * leg2)) check = true;
            else check = false;

        }

        public bool RightTriangle()
        {
            return check;
        }

        public double GetSquare()
        {
            var p = (SideA + SideB + SideC)/2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
    }
}
