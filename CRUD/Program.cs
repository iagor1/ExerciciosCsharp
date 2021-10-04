using System;
using System.IO;
namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
        
            while (true)
            {
                Console.WriteLine("Escolha uma ação com um número [1,2,3,4,5]: ");
                Console.WriteLine("1 - LER  2 - ESCREVER  3 - CRIAR  4 - EXCLUIR  5 - SAIR"); 
                    
                int escolha = int.Parse(Console.ReadLine());
                if (escolha == 1) Console.WriteLine(Arquivo.Ler());
                if (escolha == 2) try
                    {
                        StreamWriter sw = new(@"C:\Users\iagor\Documents\texto.txt");
                        sw.WriteLine("Hello World!!");
                        sw.WriteLine("salve");
                        sw.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Fim da atividade.");
                    };
                if (escolha == 3) try { Arquivo.Criar(); }

                    //Console.WriteLine("digite o caminho para criar o arquivo : ");
                    //string path = Console.ReadLine();
                    //File.Create(path);
                    //erro de acess denied :/ 

                    catch (Exception e) {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    finally {
                        Console.WriteLine("FIM.");
                    };
                if (escolha == 4) Arquivo.Apagar();

                if (escolha == 5) break;

                
            }
        
        }

    }
}
