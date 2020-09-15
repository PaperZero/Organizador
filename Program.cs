using System;
using System.IO;
namespace descoberta
{
    class Program
    {
        //path3 = @"C:\Users\Master\Desktop";
        static void Main(string[] args)
        {
            string caminho;


            Console.WriteLine("qual o caminho dos arquivos?");
            Console.WriteLine(@"EX:  C:\Users\Usuario\Desktop");

            caminho = Console.ReadLine();

            //  string[] arquivos = Directory.GetFiles(@"C:\Users\Master\Desktop", "*.txt");
            string[] arquivos = Directory.GetFiles(caminho, "*.txt");
            string[] arquivosvazios;
            string texto;


            Console.WriteLine("Arquivos:");
            foreach (string arq in arquivos)
            {

                texto = File.ReadAllText(arq);


                 if (texto.Length<=0)
                {
                    
                    arquivosvazios = arquivos;
                    Console.WriteLine("{0} - vazio", arquivosvazios);
                    

                }
                else
                {
                    Console.WriteLine(arq);
                }

                
            }

            Console.WriteLine("Posso renomear os arquivos vazios para ajudar sua organização? (sim/nao)");

            string resposta;
            string nome;
           
            resposta = Console.ReadLine();

            if (resposta == "sim")
            {
                Console.WriteLine("qual o arquivo?");
                nome = Console.ReadLine();


                File.Move(nome, nome+" - vazio");
            }
            else
            {
                Console.Read();
            }

            /*  string texto = File.ReadAllText(@"C:\Users\Master\Desktop\77.txt");

               Console.WriteLine("teste = {0}", texto);
                  */
            Console.WriteLine("feito");
            Console.Read();

                          
        }
    }
}
