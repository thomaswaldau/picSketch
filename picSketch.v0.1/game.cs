using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace picSketch
{
    class game
    {
        public string character { get; set; }
        public string attribute { get; set; }

        public void startGame(){

            string[] charArray = System.IO.File.ReadAllLines("chars.txt");
            string[] attArray = System.IO.File.ReadAllLines("att.txt");

            Random random = new Random(DateTime.Now.Millisecond);

            character = charArray[random.Next(0, charArray.Length)];
            attribute = attArray[random.Next(0, attArray.Length)];
        }

    }
}
