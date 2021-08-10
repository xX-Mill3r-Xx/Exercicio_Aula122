using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_Aula122.Entities;

namespace Exercicio_Aula122.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Resolvendo o exercicio da aula 122 do curso C# */

            Comments comentario1 = new Comments("Heve a nice trip");
            Comments comentario2 = new Comments("Wow, that's awesome!");

            Post p1 = new Post
                (
                DateTime.Parse("09/08/2021 21:25:30"),
                "Traveling to New York City",
                "I'm going to visit this wonderful country",
                12
                );
            p1.AddComment(comentario1);
            p1.AddComment(comentario2);

            Comments comentario3 = new Comments("Boa noite galera");
            Comments comentario4 = new Comments("Bora dormir!");

            Post p2 = new Post
                (
                DateTime.Parse("10/08/2021 22:05:43"),
                "Boa noite guys",
                "Até amanhã",
                15
                );
            p2.AddComment(comentario3);
            p2.AddComment(comentario4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.ReadKey();
        }
    }
}
