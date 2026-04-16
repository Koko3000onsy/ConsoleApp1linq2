using static ConsoleApp1linq2.DataSource.Source;
namespace ConsoleApp1linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //var result = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);
            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}

            //Q2
            //var result = ProductList.Skip(5).Take(5);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q3
            //var result =ProductList.OrderBy(p=>p.UnitPrice)
            //                       .TakeWhile(p=>p.UnitPrice<25);
            //foreach (var item in result)
            //{
            // Console.WriteLine(item);
            //}

            //Q4
            //var result = ProductList.Where(p=>p.Category== "Seafood")
            //                        .All(p=>p.UnitsInStock>0);
            //Console.WriteLine(result);

            //Q5
            //int[] ids = { 3, 9, 13, 18 };
            //var result = ids.Contains(9);
            //Console.WriteLine(result);

            //Q6
            //var result = ProductList.GroupBy(p=>p.Category)
            //                        .Select(g=>new { Category=g.Key, Count=g.Count()});
            //foreach (var item in result)
            //{ 
            //    Console.WriteLine(item);
            //}

            //Q7
            //var result=ProductList.GroupBy(p => p.Category)
            //                        .Select(g => new { Category = g.Key, ProductName=g.Select(p => p.ProductName) });
            //foreach (var item in result) 
            //{ 
            //    Console.WriteLine(item.Category);
            //    foreach (var productName in item.ProductName)
            //    {
            //        Console.WriteLine("  " + productName);
            //    }
            //}

            //Q8
            //var result = ProductList.GroupBy(p=> p.Category).Where(g=> g.Count()>3)
            //                        .Select(g=> new { Category=g.Key, Count=g.Count()});
            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item.Category + ": " + item.Count);
            //}

            //Q9
            //var result = from c in CustomerList
            //             group c by c.City into g
            //             select new
            //             {
            //                 country = g.Key,
            //                 count = g.Count(),
            //                 totalPrice = g.Sum(c => c.Orders.Sum(o => o.Total))
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.country}: {item.count} customers, total order price {item.totalPrice:C2}");
            //}

            //Q10
            //var result = ProductList.Sum(p=>p.UnitsInStock);
            //Console.WriteLine(result);

            //Q11
            //var result = ProductList.Max(p=>p.UnitPrice);
            //var result2 = ProductList.Min(p=>p.UnitPrice);
            //Console.WriteLine($"Max UnitPrice: {result:C2}");
            //Console.WriteLine($"Min UnitPrice: {result2:C2}");

            //Q12
            //var result = ProductList.Select(p => p.Category).Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}

            //Q13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var result = setA.Except(setB);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q15
            //var result = ProductList.ToDictionary(p=> p.ProductID, p => p);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //}

            //Q16
            //var result = ProductList.First(p => p.UnitPrice > 50);
            //Console.WriteLine(result);

            //Q17
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //if (result != null)
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("No product found with UnitPrice > 500.");

            //}
        }
    }
}
