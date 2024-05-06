using ChristmasTreePlanner;
var input = Console.ReadLine();
if (int.TryParse(input, out int n)) {
    var planner = new ChristmasTree();
    char[,] array = planner.PlanChristmasTrees(n);
    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < n; col++)
        {
            Console.Write(array[row, col]);
        }
        Console.WriteLine();
    }
} else {
    Console.WriteLine("Wrong input value");
}



