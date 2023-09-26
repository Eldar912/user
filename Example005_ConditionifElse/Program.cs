Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "eldar")
{
    Console.WriteLine("Ура, это же ELDAR!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
