using System.Collections.Generic;
using System.Linq;

public class Animal
{
    public string Name { get; set; }

    public int NumberOfLegs { get; set; }
}

public class AnimalSorter
{
    public List<Animal> Sort(List<Animal> input)
    {
        return input?.OrderBy(x => x.NumberOfLegs)
            .ThenBy(x => x.Name).ToList();
    }
}
