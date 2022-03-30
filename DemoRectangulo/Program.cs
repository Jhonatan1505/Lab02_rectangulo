using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRectangulo
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {

                double peri;
                double area;
                double x1,x2,y1,y2,x3,y3,x4,y4;


                Console.WriteLine("INGRESO DE LAS COORDENADAS");

                Console.WriteLine("Ingrese el valor de la coordenada X1:");
                x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de la coordenada Y1:");
                y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de la coordenada X2:");
                x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de la coordenada Y2:");
                y2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de la coordenada X3:");
                x3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de la coordenada Y3:");
                y3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de la coordenada X4:");
                x4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de la coordenada Y4:");
                y4 = Convert.ToInt32(Console.ReadLine());

                Rectangulo rectangulo = new Rectangulo(x1, y1, x2, y2, x3, y3, x4, y4);

                peri = rectangulo.Perimetro();

                Console.WriteLine("El perimetro del rectangulo es: {0}", peri);

                area = rectangulo.Area();

                Console.WriteLine("El area del rectangulo es: {0}", area);

                Persona persona = new Persona();

                persona.Nombres = "Jhonatan";
                persona.Apellidos = "Chumbes";

                string nombresCompletos;
                nombresCompletos = persona.DevolverNombresCompletos();

                Console.WriteLine(nombresCompletos);

                Console.Read();

            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
