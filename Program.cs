int[] oneToNine = {1,2,3,4,5,6,7,8,9};
string[] names = {"Time", "Martin", "Nikki", "Sara"};
bool[] trueOrFalse = {true, false, true, false, true, false, true, false, true, false};

List<String> icecreamFlavors = new List<String>() {
    "Mocha Chocolate Chip",
    "Keylime Pie",
    "Avocado Mango",
    "Red Bean", 
    "Vanilla Honey"
};

Dictionary<string, string> someDict = new Dictionary<string, string>();

Random rand = new Random();
someDict.Add(names[0], icecreamFlavors[rand.Next(icecreamFlavors.Count)]);
someDict.Add(names[1], icecreamFlavors[rand.Next(icecreamFlavors.Count)]);
someDict.Add(names[2], icecreamFlavors[rand.Next(icecreamFlavors.Count)]);
someDict.Add(names[3], icecreamFlavors[rand.Next(icecreamFlavors.Count)]);

// Console.WriteLine(oneToNine[0]);

// Console.WriteLine(icecreamFlavors.Count);
// Console.WriteLine(icecreamFlavors[2]);
// icecreamFlavors.RemoveAt(2);
// Console.WriteLine(icecreamFlavors.Count);

foreach(var entry in someDict){
    Console.WriteLine(entry.Key + "," + entry.Value);
}
