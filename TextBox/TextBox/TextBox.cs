using System;
using System.Collections.Generic;
using System.Text;

namespace TextBox
{
    class TextBox
    {
        public int Padding { get; set; }
        public ConsoleColor BackColor { get; set; }
        public ConsoleColor ForeColor { get; set; }
        public string Texts { get; set; }

        public TextBox()
        {
            Padding = 15;
            BackColor = ConsoleColor.Red;
            ForeColor = ConsoleColor.White;
            Texts = " ";

        }

        public TextBox(int padding, ConsoleColor backcolor, ConsoleColor forecolor, string texts)
        {
            Padding = padding;
            BackColor = backcolor;
            ForeColor = forecolor;
            Texts = texts;
        }

        
        
        public void DisplayText()
        {
                Texts = Texts.PadLeft(Padding, ' ');
                Texts = Texts.PadRight(Texts.Length + Padding, ' ');

            Console.BackgroundColor = BackColor;
            Console.ForegroundColor = ForeColor;
            //ForeColor = ConsoleColor.Cyan;
            Console.WriteLine(Texts);

        }
    }
}
