namespace C_2_base
{
    // Необходимо реализовать объектную модель геометрических фигур (прямоугольник, тругольник, круг).
    // Ко всем фигурам должно быть возможно осуществить доступ по одному имени 
    // Через это имя должно быть возможно получить доступ к площади и периметру фигур
    // Все числа пусть имееют тип double

    class figure
    {
        public double perimeter;
        public double square;

        public virtual double GetPerimeter()
        {
            return 0;
        }
        public virtual double GetSquare()
        {
            return 0;
        }
    }

    class triangle:figure
    {
        private double first_side;
        private double second_side;
        private double third_side;

        public triangle(double first_side, double second_side, double third_side)
        {
            this.first_side = first_side;
            this.second_side = second_side;
            this.third_side = third_side;
        }
        public bool IsTriangle()
        {
            if (first_side + second_side > third_side)
                if (first_side + third_side > second_side)
                    if (second_side + third_side > first_side)
                        return true;                            // triangle exists
            return false;               // 1 else for 3 cases; triangle does not exist
        }
        public override double GetPerimeter()
        {
            if (IsTriangle())
            {
                perimeter = first_side + second_side + third_side;
                return perimeter;
            }
            else return 0;
        }
        public override double GetSquare()
        {
            if (IsTriangle())
            {
                square = System.Math.Sqrt(perimeter*(perimeter-first_side)*(perimeter-second_side)*(perimeter-third_side));
                return square;
            }
            else return 0;
        }
    }

    class circle:figure
    {
        private double radius;
        public circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetPerimeter()
        {
            if (radius > 0)                                 // if circle exists
            {
                perimeter = System.Math.PI*2*radius;        // P = 2*pi*R
                return perimeter;
            }
            else return 0;
        }
        public override double GetSquare()
        {
            if (radius > 0)                                 // if circle exists
            {
                square = System.Math.PI*radius*radius;      // S = pi*R^2
                return square;
            }
            else return 0;
        }
    }

    class rectangle:figure
    {
        private double width;
        private double length;

        public rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetPerimeter()
        {
            if ((width > 0)&&(length > 0))              // if rectangle exists
            {
                perimeter = 2 * (width + length);       // P = 2*(a+b)
                return perimeter;
            }
            else return 0;
        }
        public override double GetSquare()
        {
            if ((width > 0) && (length > 0))            // if rectangle exists
            {
                square = width * length;                // S = a*b
                return square;
            }
            else return 0;
        }
    }
}
