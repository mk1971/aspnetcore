using Refit;
using System;
using System.Threading.Tasks;

namespace exemploRefit
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");
                Console.WriteLine("Informe seu cep:");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando informações ao CEP: " + cepInformado);

                var address = await cepClient.GetAdressAsync(cepInformado);

                Console.Write($"\nLogradouro:{address.Logradouro}\nBairro:{address.Bairro}\nCidade{address.Localidade}");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na consulta de cep: " + e.Message);
            }
        }
    }
}
