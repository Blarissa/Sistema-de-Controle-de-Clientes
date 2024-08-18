using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informar nome: ");
            var nome =  Console.ReadLine(); 

            Console.WriteLine("Informar endereço: ");
            var Endereco =  Console.ReadLine();

            Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
            var tipo =  Console.ReadLine().ToLower();

            if (tipo == "f")
            {
                var pf = new PessoaFisica
                {
                    Nome = nome,
                    Endereco = Endereco
                };

                Console.WriteLine("Informe o CPF: ");
                pf.CPF = Console.ReadLine();

                Console.WriteLine("Informe o RG: ");
                pf.RG = Console.ReadLine();

                Console.WriteLine("Informe o valorde compra: ");
                var valor = float.Parse(Console.ReadLine());

                pf.PagarImposto(valor);

                Console.WriteLine("-------- Pessoa Física ---------\n" +
                                  $"Nome: {pf.Nome}\n" +
                                  $"Endereço: {pf.Endereco}\n" +
                                  $"CPF: {pf.CPF}\n" +
                                  $"RG: {pf.RG}\n" +
                                  $"Valor de Compra: {pf.Valor:C}\n" +
                                  $"Valor Imposto: {pf.ValorImposto:C}\n" +
                                  $"Total a Pagar: {pf.Total:C}");
                
            }
            if (tipo == "j")
            {
                var pj = new PessoaJuridica
                {
                    Nome = nome,
                    Endereco = Endereco
                };

                Console.WriteLine("Informe o CNPJ: ");
                pj.CNPJ = Console.ReadLine();

                Console.WriteLine("Informe a IE: ");
                pj.IE = Console.ReadLine();

                Console.WriteLine("Informe o valor de compra: ");
                var valor = float.Parse(Console.ReadLine());

                pj.PagarImposto(valor);

                Console.WriteLine("-------- Pessoa Jurídica ---------\n" +
                                  $"Nome: {pj.Nome}\n" +
                                  $"Endereço: {pj.Endereco}\n" +
                                  $"CNPJ: {pj.CNPJ}\n" +
                                  $"IE: {pj.IE}\n" +
                                  $"Valor de Compra: {pj.Valor:C}\n" +
                                  $"Valor Imposto: {pj.ValorImposto:C}\n" +
                                  $"Total a Pagar: {pj.Total:C}");
                       
            }

        }
    }
}