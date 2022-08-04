Console.WriteLine("Введите имя пользователя: ");
 string username = Console.ReadLine();

 if(username.ToLower() == "маша")
 {
    Console.WriteLine("ура, это же МАША!");
 }
 else
 {
    Console.Write("Привет, ");
    Console.WriteLine(username);
 }