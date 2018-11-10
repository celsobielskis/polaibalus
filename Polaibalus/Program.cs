using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atari_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;

            Jogo meuJogo = new Jogo(80,18);
          

            while (meuJogo.rodando)
            {
                meuJogo.Update();
            }
            
        }
    }
}
