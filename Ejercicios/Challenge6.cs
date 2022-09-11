/*
 * Reto #6
 * INVIRTIENDO CADENAS
 * Fecha publicación enunciado: 07/02/22
 * Fecha publicación resolución: 14/02/22
 * Dificultad: FÁCIL
 *
 * Enunciado: Crea un programa que invierta el orden de una cadena de texto sin usar funciones propias del lenguaje que lo hagan de forma automática.
 * - Si le pasamos "Hola mundo" nos retornaría "odnum aloH"
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
    public class Challenge6
    {
        public static String Reverse(String text) 
        {
            int textCount = text.Count() - 1;
            String reverseText = "";

            for (int index = 0; index <= textCount; index++)
            {
                reverseText += text[textCount - index];
            }

            return reverseText;
        }

        public static String RecursiveReverse(String text, int index = 0, String reversedText = "")
        {
            int textCount = text.Count() - 1;
            String newReverseText = reversedText;

            newReverseText += text[textCount - index];
            if (index < textCount) 
            {
                int newIndex = index + 1;
                newReverseText = RecursiveReverse(text, newIndex, newReverseText);
            }

            return newReverseText;
        }
    }
}