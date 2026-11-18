Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("Александр", 150);

Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());
// Начало проверки здоровья
Hero lowProbe = new Hero("Проверка нижней границы", -100);
Hero highProbe = new Hero("Проверка верхней границы", 5000);
Console.WriteLine($"Нижняя граница: {lowProbe.Health}/{lowProbe.MaxHealth}");
Console.WriteLine($"Верхняя граница: {highProbe.Health}/{highProbe.MaxHealth}");
Console.WriteLine($"Александр до действий: {alexander.Health}/{alexander.MaxHealth}");

alexander.TakeDamage(30);
alexander.Heal(10);
Console.WriteLine($"Обычные действия: {alexander.Health}");
alexander.Heal(5000);
Console.WriteLine($"Большое лечение: {alexander.Health}");
alexander.Heal(-20);
Console.WriteLine($"Отказ в лечении: {alexander.Health}");
alexander.TakeDamage(5000);
Console.WriteLine($"Большой урон: {alexander.Health}; жив: {alexander.IsAlive()}");
alexander.Heal(20);
Console.WriteLine($"Восстановление: {alexander.Health}");
Console.WriteLine($"Артём без изменений: {artem.Health}/{artem.MaxHealth}");
// Конец проверки здоровья


//Задание 4
// Game GTA5 = new Game("GTA5", "Rockstar Games", 2013);
// Game CS2 = new Game("Counter-Strike 2", "VALVE", 2023);
// Game ER = new Game("ELDEN RING", "FromSoftware", 2022);
// Console.WriteLine(GTA5.Rating);
// GTA5.mut_rating(-1.0);
// Console.WriteLine(GTA5.Rating);
// GTA5.mut_rating(1.0);
// Console.WriteLine(GTA5.Rating);
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