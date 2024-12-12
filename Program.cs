namespace mod2
{
    enum Figures { Romb, Circle, Rect, Triangle }
    struct Fdata 
    {
        public int X0, Y0;      //координаты центра тяжести
        public int Color;       //цвет фигуры
        public Figures Type;    //тип фигуры
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fdata fd;
            fd.X0 = 100; fd.Y0 = 200;
            fd.Color = 0x2727FF;
            fd.Type = Figures.Romb;*/
            Fdata fd = new Fdata()
            {
                X0 = 100,
                Y0 = 200,
                Color = 0x2727FF,
                Type = Figures.Romb
            };

            Console.WriteLine($"{fd.X0}{fd.Y0} {fd.Color} {fd.Type}");
        
        }
    }
}
