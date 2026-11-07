public class Game {
    public string Name;
    public string Developer;
    public int Release_year;
    public double Rating;
    public Game(string name, string developer, int year) {
        Name = name;
        Developer = developer;
        Release_year = year;
        Rating = 0.0;
    }
    public void mut_rating(double a) {
        if (a < 0.0 || a > 5.0) {
            return;
        }
        Rating = a;
    }

}