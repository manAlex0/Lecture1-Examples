Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "таня")
{
    Console.WriteLine("Урааааа, это же Танюша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}