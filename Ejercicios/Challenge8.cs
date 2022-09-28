/*
 * Reto #8
 * DECIMAL A BINARIO
 * Fecha publicación enunciado: 18/02/22
 * Fecha publicación resolución: 02/03/22
 * Dificultad: FÁCIL
 *
 * Enunciado: Crea un programa se encargue de transformar un número decimal a binario sin utilizar funciones propias del lenguaje que lo hagan directamente.
 *
 * Información adicional:
 * - Usa el canal de nuestro discord (https://mouredev.com/discord) "🔁reto-semanal" para preguntas, dudas o prestar ayuda a la acomunidad.
 * - Puedes hacer un Fork del repo y una Pull Request al repo original para que veamos tu solución aportada.
 * - Revisaré el ejercicio en directo desde Twitch el lunes siguiente al de su publicación.
 * - Subiré una posible solución al ejercicio el lunes siguiente al de su publicación.
 *
 */

 using System;

 namespace MyApp 
 {
    public class Challenge8
    {
        public static string decimalToBinary(int number) 
        {
            int tempNumber = number;
            String binary = "";

            while (tempNumber != 0)
            {
                var reminder = tempNumber % 2;
                tempNumber /= 2;

                binary = reminder + binary;
            }

            if (String.IsNullOrEmpty(binary))
            {
                return "0";
            }
            else
            {
                return binary;
            }            
        }
    }
 }