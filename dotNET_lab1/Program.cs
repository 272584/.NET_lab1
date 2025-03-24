using System;
using System.Collections.Generic;
using System.Linq;

namespace KnapsackProblem
{
    public class Item
    {
        public int Value { get; set; }
        public int Weight { get; set; }
        public int Index { get; set; }
    }

    public class Problem
    {
        public int NumberOfItems { get; set; }
        public List<Item> Items { get; set; }

        public Problem(int numberOfItems, int seed)
        {
            NumberOfItems = numberOfItems;
            Items = new List<Item>();
            Random random = new Random(seed);

            for (int i = 0; i < numberOfItems; i++)
            {
                Items.Add(new Item
                {
                    Index = i + 1,
                    Value = random.Next(1, 11),
                    Weight = random.Next(1, 11)
                });
            }
        }

        public override string ToString()
        {
            string result = "Items:\n";
            foreach (var item in Items)
            {
                result += $"Item {item.Index}: Value = {item.Value}, Weight = {item.Weight}\n";
            }
            return result;
        }

        public Result Solve(int capacity)
        {
            var sortedItems = Items.OrderByDescending(i => (double)i.Value / i.Weight).ToList();
            List<int> selectedItems = new List<int>();
            int totalValue = 0, totalWeight = 0;

            foreach (var item in sortedItems)
            {
                if (totalWeight + item.Weight <= capacity)
                {
                    selectedItems.Add(item.Index);
                    totalWeight += item.Weight;
                    totalValue += item.Value;
                }
            }

            return new Result(selectedItems, totalValue, totalWeight);
        }
    }

    public class Result
    {
        public List<int> SelectedItems { get; set; }
        public int TotalValue { get; set; }
        public int TotalWeight { get; set; }

        public Result(List<int> selectedItems, int totalValue, int totalWeight)
        {
            SelectedItems = selectedItems;
            TotalValue = totalValue;
            TotalWeight = totalWeight;
        }

        public override string ToString()
        {
            return $"Selected Items: {string.Join(", ", SelectedItems)}\nTotal Value: {TotalValue}\nTotal Weight: {TotalWeight}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfItems, seed, capacity;

            Console.WriteLine("Enter the number of items:");
            while (!int.TryParse(Console.ReadLine(), out numberOfItems) || numberOfItems <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive integer for the number of items:");
            }

            Console.WriteLine("Enter the seed:");
            while (!int.TryParse(Console.ReadLine(), out seed))
            {
                Console.WriteLine("Invalid input. Enter an integer for the seed:");
            }

            Console.WriteLine("Enter capacity:");
            while (!int.TryParse(Console.ReadLine(), out capacity) || capacity <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive integer for the knapsack capacity:");
            }

            Problem problem = new Problem(numberOfItems, seed);
            Console.WriteLine(problem);

            Result result = problem.Solve(capacity);
            Console.WriteLine(result);
        }
    }
}
