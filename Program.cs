namespace linq01;

using static LINQ.DataSources.Source;

internal class Program
{
    static void Main(string[] args)
    {
        #region Q1
        //1.Get all products from the "Seafood" category.Print each product's name and price. 
        //var allProducts = ProductList.Select(p => new { p.ProductName, p.UnitPrice });
        //foreach (var product in allProducts)
        //{
        //    Console.WriteLine(product);
        //}
        #endregion


        #region Q2
        //2.Get a list of only the product names from ProductList.Print each name.
        //var ProductNames = ProductList.Select(p => p.ProductName);
        //foreach (var product in ProductNames)
        //{
        //    Console.WriteLine(product);
        //}
        #endregion

        #region Q3
        //3.Get all products where UnitPrice is between 10 $ 30
        //var filtredProducts = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <=30);
        //foreach (var product in filtredProducts)
        //{
        //    Console.WriteLine(product);
        //}
        #endregion

        #region Q4
        //4.Get all products that are in stock(UnitsInStock > 0) and belong to the "Condiments" category.
        //var filteredProduct = ProductList.Where(p => p.UnitPrice > 0 && p.Category.Contains("Condiments"));
        //foreach (var product in filteredProduct)
        //{
        //    Console.WriteLine(product);
        //}
        #endregion


        #region Q5
        //5.Create a new anonymous type with three properties:
        //● Name → the product name
        //● Price → the unit price
        //● StockStatus → a string: "Available" if UnitsInStock > 0, otherwise "Out of Stock"
        //● Print the result.
        var filteredProduct = ProductList.Select(p => new { p.ProductName, p.UnitPrice, 
            StockStatus =  p.UnitsInStock > 0 ? "Available" : "Out of Stock" });
        foreach (var product in filteredProduct)
        {
            Console.WriteLine(product);
        }
        #endregion


        #region Q6
        //6.Print each product's name along with its position (1 - based) in the list. Expected format: 1.Chai, 2. Chang, etc.
        #endregion

    }
}
