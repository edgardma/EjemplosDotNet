/*
 * Reto #7
 * CONTANDO PALABRAS
 * Fecha publicación enunciado: 14/02/22
 * Fecha publicación resolución: 21/02/22
 * Dificultad: MEDIA
 *
 * Enunciado: Crea un programa que cuente cuantas veces se repite cada palabra y que muestre el recuento final de todas ellas.
 * - Los signos de puntuación no forman parte de la palabra.
 * - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
 * - No se pueden utilizar funciones propias del lenguaje que lo resuelvan automáticamente.
 *
 * Información adicional:
 * - Usa el canal de nuestro discord (https://mouredev.com/discord) "🔁reto-semanal" para preguntas, dudas o prestar ayuda a la acomunidad.
 * - Puedes hacer un Fork del repo y una Pull Request al repo original para que veamos tu solución aportada.
 * - Revisaré el ejercicio en directo desde Twitch el lunes siguiente al de su publicación.
 * - Subiré una posible solución al ejercicio el lunes siguiente al de su publicación.
 *
 */

 
using System;
using System.Text.RegularExpressions;

namespace MyApp 
{
    public class Challenge7
    {
        public static void CountWords(string text) 
        {
            var words = new Dictionary<string, int>();
            string result = Regex.Replace(text.ToLower(), "[^a-z0-9]"," ");
            string[] subs = result.Split(' ');
            
            foreach (var key in subs)
            {
                if (!String.IsNullOrEmpty(key))
                {
                    if (words.ContainsKey(key)) 
                    {
                        words[key] =  words[key] + 1;
                    } 
                    else 
                    {
                        words[key] = 1;
                    }
                }
            }

            foreach (var item in words)
            {
                if (item.Value == 1)
                {
                    Console.WriteLine($"'{item.Key}' se ha repetido {item.Value} vez");
                } 
                else
                {
                    Console.WriteLine($"'{item.Key}' se ha repetido {item.Value} veces");
                }
            }
        }
    }
}