/*
 * Reto #4
 * ÁREA DE UN POLÍGONO
 * Fecha publicación enunciado: 24/01/22
 * Fecha publicación resolución: 31/01/22
 * Dificultad: FÁCIL
 *
 * Enunciado: Crea UNA ÚNICA FUNCIÓN (importante que sólo sea una) que sea capaz de calcular y retornar el área de un polígono.
 * - La función recibirá por parámetro sólo UN polígono a la vez.
 * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
 * - Imprime el cálculo del área de un polígono de cada tipo.
 *
 * Información adicional:
 * - Usa el canal de nuestro discord (https://mouredev.com/discord) "🔁reto-semanal" para preguntas, dudas o prestar ayuda a la acomunidad.
 * - Puedes hacer un Fork del repo y una Pull Request al repo original para que veamos tu solución aportada.
 * - Revisaré el ejercicio en directo desde Twitch el lunes siguiente al de su publicación.
 * - Subiré una posible solución al ejercicio el lunes siguiente al de su publicación.
 *
 */

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Challenge4
    {
        public static double Area(Polygon polygon) 
        {
            polygon.PrintArea();

            return polygon.Area();
        }
    }

    public interface Polygon
    {
        public double Area();

        public void PrintArea();
    }

    public class Triangle : Polygon
    {
        private double baseTriangle;
        private double height;

        public Triangle(double baseTriangle, double height)
        {
            this.baseTriangle = baseTriangle;
            this.height = height;
        }

        public double Area() 
        {
            return (baseTriangle * height) / 2;
        }

        public void PrintArea()
        {
            Console.WriteLine("El área del triangulo es: " + this.Area());
        }
    }

    public class Rectangle : Polygon
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double Area() 
        {
            return length * width;
        }

        public void PrintArea()
        {
            Console.WriteLine("El área del rectangulo es: " + this.Area());
        }
    }

    public class Square : Polygon
    {
        private double side;        

        public Square(double side)
        {
            this.side = side;
        }

        public double Area() 
        {
            return side * side;
        }

        public void PrintArea()
        {
            Console.WriteLine("El área del cuadrado es: " + this.Area());
        }
    }
}