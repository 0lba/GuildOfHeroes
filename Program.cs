// Probe.Run();
Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);
alexander.TakeDamage(10);
alexander.Heal(10);
Guild guild = new Guild("Гильдия героев");
guild.AddHero(yaroslav);
guild.AddHero(anastasia);
guild.AddHero(artem);
guild.AddHero(alexander);
guild.AddHero(sergey);
List<Hero> members = guild.GetMembers();
Console.WriteLine($">>> {guild.Name}: перекличка <<<");
Console.WriteLine($"Участников: {guild.MemberCount}");
if (members.Count > 0) {
    Console.WriteLine($"Первый: {members[0].Name}");
    Console.WriteLine($"Последний: {members[guild.MemberCount - 1].Name}");
}
Console.WriteLine();
foreach (Hero hero in members) {
    Console.WriteLine(hero.GetInfo());
    Console.WriteLine();
}
Hero? found = guild.FindHeroByName(" аРтЁм ");
if (found != null) {
    Console.WriteLine($"Найден по запросу « аРтЁм »: {found.Name}");
}
else {
    Console.WriteLine("По запросу « аРтЁм » никого нет.");
}
Console.WriteLine($"Повтор Александра принят: {guild.AddHero(alexander)}");
Console.WriteLine($"Удалён отсутствующий: {guild.RemoveHero("Борис")}");
Console.WriteLine($"Участников после проверок: {guild.MemberCount}");
Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {guild.CountHealthy(120)}");
if (members.Count > 0) {
    Hero strongest = members[0];
    foreach (Hero i in members) {
        if (i.Health > strongest.Health) {
            strongest = i;
        }
    }
    Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
}

//Задание 4
// Game GTA5 = new Game("GTA5", "Rockstar Games", 2013);
// Game CS2 = new Game("Counter-Strike 2", "VALVE", 2023);
// Game ER = new Game("ELDEN RING", "FromSoftware", 2022);
// Game Portal = new Game("Portal", "VALVE", 2007);
// Portal.mut_rating(4.9);
// Console.WriteLine($"До действий: {GTA5.Rating}");
// GTA5.mut_rating(-1.0);
// Console.WriteLine($"После mut_rating(-1.0): {GTA5.Rating}");
// GTA5.mut_rating(1.0);
// Console.WriteLine($"После mut_rating(1.0): {GTA5.Rating}");
// Console.WriteLine();
// Library library = new Library("Игры");
// library.Games.Add(GTA5);
// library.Games.Add(CS2);
// library.Games.Add(ER);
// library.Games.Add(Portal);
// if (library.Games.Count > 0)
// {
//     Console.WriteLine($"Всего: {library.Games.Count}");
//     Console.WriteLine($"1ый элемент: {library.Games[0].Name}");
//     Console.WriteLine($"2ой элемент: {library.Games[library.Games.Count - 1].Name}");
// }
// Console.WriteLine();
// int c = 0;
// foreach (Game i in library.Games) {
//     if (i.Developer == "VALVE") {
//         c++;
//     }
//     Console.WriteLine(i.GetInfo());
//     Console.WriteLine();
// }
// Console.WriteLine($"Кол-во игр от VALVE: {c}");
// CS2.mut_rating(1.2);
// Console.WriteLine($"Рейтинг CS2: {library.Games[1].Rating}");