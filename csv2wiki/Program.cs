using System;
using Microsoft.VisualBasic.FileIO;

namespace csv2wiki
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage:\tcsv2wiki input-csv [output-wiki]");
                return;
            }
            String input = args[0];
            String output = args.Length > 1 ? args[1] : System.IO.Path.ChangeExtension(input, ".txt");

           var sw =new System.IO.StreamWriter(output,false);
            sw.WriteLine("{| class=\"wikitable\"");
            sw.WriteLine("|+ Title");

            var parser = new TextFieldParser(input,System.Text.Encoding.GetEncoding("Shift_JIS"));
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            parser.CommentTokens = new String[1] { "#" };
            while (!parser.EndOfData)
            {
                string[] row = parser.ReadFields();
                sw.WriteLine("|-");
                for (int i = 0; i < row.Length; i++)
                {
                    sw.Write(i == 0 ? "| " : " || ");
                    sw.Write(row[i]);
                }
                sw.WriteLine();
            }
            sw.WriteLine("|}");
            sw.Close();

        }
    }
}
