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
        }
    }
}
