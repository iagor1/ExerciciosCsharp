using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD {
    public class Arquivo {
        public static string Ler() {
            
                string Path = @"C:\Users\iagor\Documents\texto.txt";
                StreamReader t = new(Path);
                t = File.OpenText(Path);
                string lines = t.ReadToEnd();
                t.Close();
                return lines;
            }

        public static void Apagar() {
            try {
                string caminho = @"C:\Users\iagor\Documents\texto.txt";
                File.Delete(caminho);
            }
            catch (Exception e) {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally {
                Console.WriteLine("FIM.");
            };

        }

        public static void Criar() {
            try {
                string caminho = @"C:\Users\iagor\Documents\texto.txt";
                File.Create(caminho);
            }
            catch (Exception e) {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally {
                Console.WriteLine("FIM.");
            };
        }


    }
}
