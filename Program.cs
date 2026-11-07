Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
yaroslav.Health = 75;
yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");
yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");

//Задание 4
// Game GTA5 = new Game("GTA5", "Rockstar Games", 2013);
// Game CS2 = new Game("Counter-Strike 2", "VALVE", 2023);
// Game ER = new Game("ELDEN RING", "FromSoftware", 2022);
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