using BulbService.Service;

Console.WriteLine("Bulb Simulator");
static int GetValidInput(string prompt)
{
    int value;
    while (true)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out value) && value >= 0)
        {
            return value;
        }
        Console.WriteLine("Invalid input. Please enter a non-negative numeric value.");
    }
}

while (true)
{
    int numPeople = GetValidInput("Enter the number of people in the room (0 to exit): ");

    if (numPeople == 0)
    {
        break;
    }

    int numBulbs = GetValidInput("Enter the number of bulbs in the hallway: ");

    var simulator = new BulbSimulator();
    var bulbs = simulator.Simulate(numBulbs);

    for (int i = 0; i < numBulbs; i++)
    {
        Console.WriteLine($"Bulb #{i + 1} --> {(bulbs[i].IsOn ? "ON" : "OFF")}");
    }

    Console.WriteLine();
}
//The final state of a bulb is determined by how many times it has been toggled.
//If the number of times a bulb is toggled is an odd number, it will end up in the "on" state.
//If the number of times a bulb is toggled is an even number, it will end up in the "off" state.