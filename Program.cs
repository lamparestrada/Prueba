using Calculadora;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("con esta calculadora podras saber en cuanto te queda tu nota");
        Notas Nota = new Notas();
        Console.WriteLine("Ingrese la nota del quiz del corte 1");
        double quiz1 = double.Parse(Console.ReadLine());
        System.Console.WriteLine("ingrese el valor del taller del corte 1");
        double taller1 = double.Parse(Console.ReadLine());
        System.Console.WriteLine("ingrese el valor del parcial del corte 1");
        double parcial1 = double.Parse(Console.ReadLine());
        Console.WriteLine("su nota es " + Nota.Calculadora1(quiz1, taller1, parcial1));
      
        Console.WriteLine("Ingrese la nota del quiz del corte 2");
        double quiz2 = double.Parse(Console.ReadLine());
        System.Console.WriteLine("ingrese el valor del taller del corte 2");
        double taller2 = double.Parse(Console.ReadLine());
        System.Console.WriteLine("ingrese el valor del parcial del corte 2");
        double parcial2 = double.Parse(Console.ReadLine());
        Console.WriteLine("su nota es " + Nota.Calculadora1(quiz2, taller2, parcial2));

        System.Console.WriteLine("ingrese el valor del quiz del corte 3");
        double quiz3 = double.Parse(Console.ReadLine());
        System.Console.WriteLine("ingrese el valor del taller del corte 3");
        double taller3 = double.Parse(Console.ReadLine());
        System.Console.WriteLine("ingrese el valor del parcial del corte 3");
        double parcial3 = double.Parse(Console.ReadLine());
        Console.WriteLine("su nota es " + Nota.Calculadora2(quiz3, taller3, parcial3));
        

        System.Console.WriteLine("SU NOTA FINAL ES:"+Nota.ponderado);
    }
}