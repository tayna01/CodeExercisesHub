using CodeExercisesHub.ExercisesHub;

class Program
{
    private static void Main(string[] args)
    {
        // Tarefa 1
        var resultTaskOne = TaskOne.Summation(5);
        Console.WriteLine($"Resultado da Tarefa 1: {resultTaskOne}");
        
        // Tarefa 2
        var resultTaskTwo = TaskTwo.NoSpace("7634 m     6h   83 8 90 uykj j l l jk kj");
        Console.WriteLine($"Resultado da Tarefa 2: {resultTaskTwo}");
        
        // Tarefa 3
        var resultTaskThree = TaskThree.Kata.Greet();
        Console.WriteLine($"Resultado da Tarefa 3: {resultTaskThree}");
    }
}