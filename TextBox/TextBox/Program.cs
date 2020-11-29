using System;

namespace TextBox
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox myText = new TextBox();

            myText.Padding = 20;
            myText.BackColor = ConsoleColor.Cyan;
            myText.ForeColor = ConsoleColor.DarkBlue;
            myText.Texts = "Hi folks!";

            myText.DisplayText();

            myText.Padding = 50;
            myText.BackColor = ConsoleColor.DarkYellow;
            myText.ForeColor = ConsoleColor.Yellow;
            myText.Texts = "Goodbye yall!";

            myText.DisplayText();
        }
    }
}
