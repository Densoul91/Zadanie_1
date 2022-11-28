internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Добрый день!\nВведите ваши данные:");

        Console.Write("\n1. Имя: ");
        var name = Console.ReadLine();

        Console.Write("2. Фамилия: ");
        var lastname = Console.ReadLine();

        Console.Write("3. Отчество: ");
        var patronymic = Console.ReadLine();

        Console.Write("4. Ваш email: ");
        var mail = Console.ReadLine();

        Console.Write("5. Номер телефона: ");
        var phone = Console.ReadLine();

        Console.Write("6. Фирма, в которой работаете: ");
        var job = Console.ReadLine();

        Console.WriteLine("\nВведеные данные:\n");////
        Console.Write($"{lastname} {name} {patronymic}\nТелефон: {phone}\nEmail: {mail}\nРаботает в {job}");
    }
}