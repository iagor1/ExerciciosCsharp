using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
   public class Arquivo {
       public static string Ler() {
            Console.WriteLine("----------------------------------");
            string Path = @"C:\Users\iagor.luchesi\Documents\Dev\teste.txt";
            StreamReader t = new StreamReader(Path);
            t = File.OpenText(Path);
            string lines = t.ReadToEnd();
            t.Close();
            return lines;

        }

        public static void Apagar()
        {
            string caminnho = @"C:\Users\iagor.luchesi\Documents\Dev\teste.txt";
            File.Delete(caminnho);
        }

    /*    public static string Escrever()
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(@"C:\Users\iagor.luchesi\Documents\Dev\texto.txt");
                //Write a line of text
                sw.WriteLine("Hello World!!");
                //Write a second line of text
                sw.WriteLine("cu");
                //Close the file
                sw.Close();
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Burro errou Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Nice acabou aqui.");
            }

        }*/

    }
}
