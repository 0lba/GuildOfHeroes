Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");
yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");
yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");
bool yaroslavAlive = yaroslav.IsAlive();
Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
Console.WriteLine($"Артём жив: {artem.IsAlive()}");

if (yaroslavAlive) {
    Console.WriteLine("Ярослав может продолжать приключение.");
}
else {
    Console.WriteLine("Ярослав больше не может сражаться.");
}
string info = yaroslav.GetInfo();
Console.WriteLine("Строка получена. Сейчас выведем её:");
Console.WriteLine(info);

Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());



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