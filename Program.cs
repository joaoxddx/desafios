
using static System.Console;
using System.Reflection;
using Desafio_C_.models;


Veiculo operacoes = new Veiculo();


float precoInicial, precoHora;

string modelo,placaEnt, placaSai,hora;
WriteLine("Digite o valor da chegada:");
precoInicial=Convert.ToInt32(ReadLine());
WriteLine("Digite o valor da hora:");
precoHora=Convert.ToInt32(ReadLine());
int opcao = -1;
while (opcao !=0)
{
    WriteLine("\nDigite qual opção deseja:\n" + 
    "\n1-Cadastrar veiculo"+
    "\n2-Listar veiculo"+
    "\n3-Remover veiculo"+
    "\n0-Sair\n");
    opcao = Convert.ToInt32(ReadLine());
    switch (opcao)
    {
        case 1:
        {
            WriteLine("Digite o modelo do carro:");
            modelo=ReadLine();
            WriteLine("Digite a placa do carro:");
            placaEnt=ReadLine();
            WriteLine("\nAperte enter para confirmar a entrada do veiculo");
            ReadLine();
            WriteLine("Veiculo estacionado!\n\n");
            operacoes.Adicionar(modelo,placaEnt);
            break;
    
        }
        case 2:
        {
            operacoes.Mostrar();
            break;
        }
        case 3:
        {
            
            WriteLine("Digite a placa do carro que irá sair:");
            placaSai=ReadLine();

            operacoes.Remover(placaSai, precoHora, precoInicial);
            break;
        }
        
    }
}