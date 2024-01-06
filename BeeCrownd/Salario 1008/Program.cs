using System;

class Program {
    public static void Main(string[] args) {

        int funcionario = int.Parse(Console.ReadLine());
        int hora = int.Parse(Console.ReadLine());
        double salario = double.Parse(Console.ReadLine());

        double salarioFinal = hora * salario;
        Console.WriteLine("NUMBER = " + funcionario + "\n" + "SALARY = U$ " + salarioFinal.ToString("F2"));
    }
}