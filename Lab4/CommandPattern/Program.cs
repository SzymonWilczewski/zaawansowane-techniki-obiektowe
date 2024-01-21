using System;
using System.Numerics;

// Complete the sample task based on:
// https://pierresimondelaplace.gitlab.io/wsb-zaawansowane-techniki-obiektowe/WSB_ZaawansowaneTechnikiObiektowe.pdf

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = new Character();
            MoveCommand up = new MoveCommand(character, new Vector3(0f, 1f, 0f));
            MoveCommand left = new MoveCommand(character, new Vector3(-1f, 0f, 0f));
            MoveCommand down = new MoveCommand(character, new Vector3(0f, -1f, 0f));
            MoveCommand right = new MoveCommand(character, new Vector3(1f, 0f, 0f));

            character.Move(up);
            Console.WriteLine(character.ToString());

            character.Move(left);
            Console.WriteLine(character.ToString());

            character.Move(down);
            Console.WriteLine(character.ToString());

            character.Move(right);
            Console.WriteLine(character.ToString());

            character.ComeBack();
            Console.WriteLine(character.ToString());

            character.MoveAgain();
            Console.WriteLine(character.ToString());

            Console.ReadLine();
        }
    }
}
