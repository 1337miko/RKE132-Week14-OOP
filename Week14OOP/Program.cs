Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog();

Console.WriteLine($"My dogs name is {myDog._name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog._name}.");

myDog.Rename("Bad Boy");
Console.WriteLine($"Level of happiness: {myDog.LevelOfHappiness}");

while (myDog.LevelOfHappiness != 5)
{
    myDog.Bark()
}

myDog.WagTail();


class Dog
{
    private string _name;
    private int _levelOfHappiness;

    public Dog(string name)
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHappiness

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }
}