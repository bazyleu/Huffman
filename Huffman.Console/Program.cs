using System;
using System.IO;

namespace Huffman.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {
                    System.Console.WriteLine(GetHelp());
                    return;
                }

                if (args[0] == "-e")
                {
                    Encode(args[1]);
                }

                if (args[0] == "-d")
                {
                    Decode(args[1]);
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

        }

        public static void Encode(string fileName)
        {
            File.WriteAllBytes(fileName+".haf", HuffmanEncoder.Encode(File.ReadAllBytes(fileName)));
            System.Console.WriteLine("done.");
        }

        public static void Decode(string fileName)
        {
            File.WriteAllBytes(fileName.Replace(".haf", String.Empty), HuffmanEncoder.Decode(File.ReadAllBytes(fileName)));
            System.Console.WriteLine("done.");
        }

        private static string GetHelp()
        {
            return "[-e FILENAME] for encode file \n" +
                   "[-d FILENAME] for decode *.haf file";
        }
    }
}
