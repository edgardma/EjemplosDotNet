/*
 * Reto #0
 * EL FAMOSO "FIZZ BUZZ"
 * Fecha publicación enunciado: 27/12/21
 * Fecha publicación resolución: 03/01/22
 * Dificultad: FÁCIL
 * Enunciado: Escribe un programa que muestre por consola (con un print) los números de 1 a 100 (ambos incluidos y con un salto de línea entre cada impresión), sustituyendo los siguientes:
 * - Múltiplos de 3 por la palabra "fizz".
 * - Múltiplos de 5 por la palabra "buzz".
 * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
 *
 * Información adicional:
 * - Usa el canal de nuestro discord (https://mouredev.com/discord) "🔁reto-semanal" para preguntas, dudas o prestar ayuda a la acomunidad.
 * - Puedes hacer un Fork del repo y una Pull Request al repo original para que veamos tu solución aportada.
 * - Revisaré el ejercicio en directo desde Twitch el lunes siguiente al de su publicación.
 * - Subiré una posible solución al ejercicio el lunes siguiente al de su publicación.
 * https://github.com/mouredev/Weekly-Challenge-2022-Kotlin/blob/main/app/src/main/java/com/mouredev/weeklychallenge2022/Challenge0.kt
 */
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Challenge0
    {
        public static void FizzBuzz() 
        {
            for (int index=1; index <= 100; index++)
            {
                bool divisibleByTree = index % 3 == 0;
                bool divisibleByFive = index % 5 == 0;

                if (divisibleByTree && divisibleByFive)
                {
                    Console.WriteLine("fizzbuzz");
                } else if (divisibleByTree) {
                    Console.WriteLine("fizz");
                } else if (divisibleByFive) {
                    Console.WriteLine("buzz");
                } else {
                    Console.WriteLine(index);
                }
            }
        }
    }
}