using LinqTest01;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // lista intów
        var listOfInts = new List<int>
        {
            3, 1, 0, 543, 11, 2, 3, 88, 64, 123, 25, 47
        };

        // lista stringów
        var listOfStrings = new List<string>
        {
            "Ala",
            "Włodek",
            "olga",
            "Dramatyczna rzeczywistość",
            "Komputer typu",
            "",
            "",
            "1234",
            "bezzmian"
        };

        // lista userów
        var listOfUsers = new List<User>
        {
            new User
            {
                Id = 1,
                Firstname   = "Albert",
                Lastname    = "Marcicki",
                Email       = "example@gmail.com"
            },
            new User
            {
                Id = 5,
                Firstname   = "Bartosz",
                Lastname    = "Brzęczyk",
                Email       = "fiolek78@gmail.com"
            },
            new User
            {
                Id = 55,
                Firstname   = "Miłosz",
                Lastname    = "Kromka",
                Email       = "kromka1994@bok.com"
            },
            new User
            {
                Id = 12,
                Firstname   = "Daniel",
                Lastname    = "Wonsz",
                Email       = "dwonsz@gmail.taz"
            }

        };
    }
}