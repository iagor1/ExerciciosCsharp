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
                Console.WriteLine("1 - LER  2 - ESCREVER  3 - ATUALIZAR  4 - EXCLUIR  5 - SAIR"); 
                    
                int escolha = int.Parse(Console.ReadLine());
                if (escolha == 1) Console.WriteLine(Arquivo.Ler());
                if (escolha == 2) try
                    {
                        //Pass the filepath and filename to the StreamWriter Constructor
                        StreamWriter sw = new StreamWriter(@"C:\Users\iagor.luchesi\Documents\Dev\teste.txt");
                        //Write a line of text
                        sw.WriteLine("Hello World!!");
                        //Write a second line of text
                        sw.WriteLine("From the StreamWriter class");
                        //Close the file
                        sw.Close();
                        // refazer ta mt ruim
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Fim da atividade.");
                    };

                if (escolha == 4) try
                {
                        Arquivo.Apagar();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("FIM.");
                }; 

                if (escolha == 5) break;

                
            }
        
        }

    }
}
