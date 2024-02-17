using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Console.WriteLine("Inheritance with Event Planning");
        Console.WriteLine();

        // Adresses
        Address address1 = new Address("USA", "Utah", "Dover", "100 LAKESHORE");
        Address address2 = new Address("Russia", "Moscow Obl", "Moscow", "Lenina 35");
        Address address3 = new Address("Germany", "Siegfried", "Schulte", "Gasse 6 59678 Karben");

        // Lecture Event
        Lecture lecture = new Lecture(
            title: "About health",
            description: "Lecture About health activities",
            time: "15:30",
            date: "1 Nov",
            address: address1,
            speakerName: "Danny Thomas",
            capacity: 30
        );

        // Reception Event
        Reception reception = new Reception(
            title: "About fashion",
            description: "About woman fashion",
            time: "10:30",
            date: "5 Nov",
            address: address2,
            email: "blablabla@gmail.com"
        );

        // Outdoor Event
        Outdoor outdoor = new Outdoor(
            title: "About fashion",
            description: "About woman fashion",
            time: "10:30",
            date: "5 Nov",
            address: address3,
            weatherStatement: "Cloudy"
        );

        // Messages
        Console.WriteLine(lecture.ShowShortDescription());
        Console.WriteLine();
        Console.WriteLine(lecture.ShowStandardDetails());

        Console.WriteLine("-----------------");
        Console.WriteLine(reception.ShowShortDescription());
        Console.WriteLine();
        Console.WriteLine(reception.ShowStandardDetails());
        
        Console.WriteLine("-----------------");
        Console.WriteLine(outdoor.ShowShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoor.ShowStandardDetails());
    }
}