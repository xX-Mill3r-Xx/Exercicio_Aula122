using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aula122.Entities
{
    class Comments
    {
        public string Text { get; set; }

        public Comments()
        {

        }

        public Comments(string text)
        {
            Text = text;
        }
    }
}
