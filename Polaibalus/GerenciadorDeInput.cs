using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atari_II
{

    class GerenciadorDeInput
    {
        public static ConsoleKey teclaApertada;

        public void ChecaInput()
        {
            if (Console.KeyAvailable)
            {
                teclaApertada = Console.ReadKey(true).Key;
            }

            else
            {
                teclaApertada = 0;
            }
        }
    }
}
