using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta_OOP;

namespace MyApp
{

    public class Pessoa
    {
        private string cpf;

        public string CPF
        {
            get { return cpf; }

            set
            {
                if (value.Length == 11 && value.HasOnlyDigits())
                    cpf = value;

                else
                    throw new Exception("O CPF é invalido, deve possuir 11 digitos");
            }
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double IMC

        {

            get
            {
                return (this.Peso / (this.Altura * this.Altura));
            }
        }

        public Pessoa(string nome, string sobrenome, DateTime dataNascimento, string cpf)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNascimento;
            this.CPF = cpf;
        }

        public Pessoa(string nome, string sobrenome, DateTime dataNascimento, string cpf, double peso, double altura) : this(nome, sobrenome, dataNascimento, cpf)
        {
            this.Peso = peso;
            this.Altura = altura;
        }

        public void Comer(double pesoKg)
        {
            this.Peso += pesoKg;
            Console.WriteLine($"O peso do {this.Nome} é {this.Peso} kg de comida");
        }

        public void Comer(int calorias)
        {
            this.Peso += calorias / 30000;
            Console.WriteLine($"O {this.Nome} {this.Sobrenome} comeu {calorias} calorias");
        }

        public void Correr(double distanciaKm, int dias = 1)
        {
            this.Peso -= (distanciaKm / 40) * dias;
            Console.WriteLine($"O {this.Nome} {this.Sobrenome} correu {distanciaKm} km em {dias} dias");
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome Completo: {this.Nome} {this.Sobrenome}");
            Console.WriteLine($"Data de Nascimento: {Math.Truncate((DateTime.Now - this.DataNascimento).TotalDays / 365.25)} anos");
            Console.WriteLine($"IMC: {this.IMC:F2}");
            Console.WriteLine($"CPF: {this.CPF}");
            Console.WriteLine($"Peso: {this.Peso} kg");
            Console.WriteLine($"Altura: {this.Altura} cm");
        }

        public void AvaliarIMC() // Método que avalia o IMC do cliente
        {
            double imc = this.IMC; // Obtendo o IMC do cliente  
            if (imc < 18.5)
            {
                Console.WriteLine($"{this.Nome} {this.Sobrenome} está abaixo do peso.");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine($"{this.Nome} {this.Sobrenome} está dentro da norma.");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine($"{this.Nome} {this.Sobrenome} está com sobrepeso.");
            }
            else
            {
                Console.WriteLine($"{this.Nome} {this.Sobrenome} está com obesidade.");
            }
        }
    }











}


