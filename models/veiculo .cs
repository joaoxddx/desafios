using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace Desafio_C_.models
{
    public class Veiculo 
    {
        List<String> modelo = new List<string>();
        List<String> Placa = new List<string>();
        
        public void Adicionar(string nome, string placa)
        {
            modelo.Add(nome);
            Placa.Add(placa);
        }
        public void Mostrar()
        {
            for(int i=0; i < modelo.Count; i++)
            {
                WriteLine($"Veiculo da placa{Placa[i]} do modelo {modelo [i]}");
            }
        }
        public void Remover(string placaremov, float valorHora, float precoInicial)
        {
            
            for(int i=0; i < Placa.Count; i++)
            {
                if(placaremov == Placa[i])
                {
                    WriteLine("Quanto tempo o carro ficou no estacionamento:");
                    string hora=ReadLine();
                    float horaCarro = float.Parse(hora);
                    WriteLine($"O valor a ser pago pelo carro seria: R${(horaCarro*valorHora)+precoInicial}");
                    
                }
                else WriteLine("O carro não esta no estacionamento! Tente novamente com uma placa valida!");
            }
        }
    }
}