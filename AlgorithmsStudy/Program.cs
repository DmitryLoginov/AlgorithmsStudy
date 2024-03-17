
//var items = new List<int>() {5, 2, 3, 1, 4};
//var bubble = new BubbleSort<int>(new List<int>(items));

var items = new List<int>();
var count = 10;
var random = new Random();

for (int i = 0; i < count; i++)
{
    items.Add(random.Next(0, 100));
}

var bubble = new BubbleSort<int>(new List<int>(items));

items.Sort();
bubble.Sort();

for (int i = 0; i < items.Count; i++)
{
    if (items[i] != bubble.Collection[i])
    {
        System.Console.WriteLine("failed");
    }
}

System.Console.WriteLine("end");
