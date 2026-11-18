Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);

alexander.TakeDamage(10);
alexander.Heal(10);

Console.WriteLine(">>> Участники готовы <<<");
Console.WriteLine();
Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());
Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");

//Задание 4
// Game GTA5 = new Game("GTA5", "Rockstar Games", 2013);
// Game CS2 = new Game("Counter-Strike 2", "VALVE", 2023);
// Game ER = new Game("ELDEN RING", "FromSoftware", 2022);
// Console.WriteLine($"До действий: {GTA5.Rating}");
// GTA5.mut_rating(-1.0);
// Console.WriteLine($"После mut_rating(-1.0): {GTA5.Rating}");
// GTA5.mut_rating(1.0);
// Console.WriteLine($"После mut_rating(1.0): {GTA5.Rating}");
// Console.WriteLine("");
// Console.WriteLine(">>> Игра 1 <<<");
// Console.WriteLine($"Название: {GTA5.Name}");
// Console.WriteLine($"Разработчик: {GTA5.Developer}");
// Console.WriteLine($"Год релиза: {GTA5.Release_year}");
// Console.WriteLine($"Рейтинг: {GTA5.Rating}");
// Console.WriteLine();
// Console.WriteLine(">>> Игра 2 <<<");
// Console.WriteLine($"Название: {CS2.Name}");
// Console.WriteLine($"Разработчик: {CS2.Developer}");
// Console.WriteLine($"Год релиза: {CS2.Release_year}");
// Console.WriteLine($"Рейтинг: {CS2.Rating}");
// Console.WriteLine();
// Console.WriteLine(">>> Игра 3 <<<");
// Console.WriteLine($"Название: {ER.Name}");
// Console.WriteLine($"Разработчик: {ER.Developer}");
// Console.WriteLine($"Год релиза: {ER.Release_year}");
// Console.WriteLine($"Рейтинг: {ER.Rating}");