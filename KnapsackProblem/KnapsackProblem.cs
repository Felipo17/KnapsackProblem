using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("KnapsackUnitTests")]
[assembly: InternalsVisibleTo("KnapsackGUI")]

namespace KnapsackProblem
{
    public class Item
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int Weight { get; set; }

        public Item(int id, int value, int weight)
        {
            Id = id;
            Value = value;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Value: {Value}, Weight: {Weight} \n";
        }
    }
    public class Problem
    {
        public int ItemsNumber { get; }
        public List<Item> Items { get; }

        public Problem(int n, int seed, List<Item> externalItems = null)
        {
            Items = externalItems ?? new List<Item>();
            if (externalItems == null)
            {
                Random random = new Random();
                ItemsNumber = n;

                for (int i = 0; i < n; i++)
                {
                    int value = random.Next(1, 11);
                    int weight = random.Next(1, 11);
                    Items.Add(new Item(i+1, value, weight));
                }
            }
            else
            {
                ItemsNumber = Items.Count;
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach (var item in Items)
            {
                result += item.ToString() + "\n";
            }
            return result.TrimEnd();
        }

        public Result Solve(int capacity)
        {
            var sortedItems = Items.OrderByDescending(x => (double)x.Value / x.Weight).ToList();

            List<int> itemsId = new List<int>();
            int valueSum = 0, weightSum = 0;

            foreach (var item in sortedItems)
            {
                if (weightSum + item.Weight <= capacity)
                {
                    weightSum += item.Weight;
                    valueSum += item.Value;
                    itemsId.Add(item.Id);
                }
            }
            return new Result(itemsId, valueSum, weightSum);
        }
    }

    public class Result
    {
        public List<int> ItemsId { get; }
        public int ValueSum { get; }
        public int WeightSum { get; }

        public Result(List<int> itemsId, int valueSum, int weightSum)
        {
            ItemsId = itemsId;
            ValueSum = valueSum;
            WeightSum = weightSum;
        }

        public override string ToString()
        {
            return $"Items in backpack: {string.Join(", ", ItemsId)},\n " +
                   $"Total value: {ValueSum}, \n" + 
                   $"Total weight: {WeightSum}";
        }
    }

    class KnapsackProblem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the seed: ");
            int seed = int.Parse(Console.ReadLine());

            Problem problem = new Problem(n, seed);

            Console.WriteLine(problem);

            Console.WriteLine("Enter the backpack capacity: ");
            int backpackCapacity = int.Parse(Console.ReadLine());

            Result result = problem.Solve(backpackCapacity);
            Console.WriteLine(result);
        }
    }
}
