public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Seu nome:");
        var nome = Console.ReadLine();

        Console.Write("Possui atraso de empréstimo? (true/false): ");
        bool.TryParse(Console.ReadLine(), out bool atraso);

        Console.Write("Quantos empréstimos possui atualmente? : ");
        int.TryParse(Console.ReadLine(), out int emprestimos);

        if(!atraso && emprestimos < 3){
            Console.WriteLine($"{nome}, você pode realizar um empréstimo!");
        }
        else{
            Console.WriteLine($"{nome}, você não pode realizar um empréstimo!");
        }
    }
}
