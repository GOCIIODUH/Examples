System.Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    System.Console.WriteLine("Ура, это же Маша");
}
else
{
    System.Console.Write("Привет, ");
    System.Console.WriteLine(username);
}