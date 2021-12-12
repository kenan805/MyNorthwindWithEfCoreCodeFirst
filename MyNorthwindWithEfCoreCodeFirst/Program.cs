// See https://aka.ms/new-console-template for more information

using MyNorthwindWithEfCoreCodeFirst.Context;
using MyNorthwindWithEfCoreCodeFirst.Models;

using (var context = new MyDbContext())
{
    context.Categories?.AddRange(
        new List<Category>()
        {
        new Category { Name = "Beverages", Description = "Soft drinks, coffees, teas, beers, and ales" },
        new Category { Name = "Meat/Poultry", Description = "Prepared meats" },
        new Category { Name = "Seafood", Description = "Seaweed and fish" }
        });

    context.Customers?.AddRange(
    new List<Customer>()
    {
        new Customer { CompanyName = "Alfreds Futterkiste", Address = "Obere Str. 57", City = "Berlin", Phone="030-0074321"},
        new Customer { CompanyName = "Berglunds snabbköp", Address = "12, rue des Bouchers", PostalCode= "3012", City = "London", Phone="91.24.45.40", ContactTitle="Sven Ottlieb"}
    });

    context.Employees?.AddRange(
        new Employee { FirstName = "Nancy", LastName= "Davolio", TitleOfCourtesy="Ms.", City= "Seattle" },
        new Employee { FirstName = "Margaret", LastName= "Peacock", TitleOfCourtesy="Mrs.", Address = "4110 Old Redmond Rd." },
        new Employee { FirstName = "Andrew", LastName= "Fuller", TitleOfCourtesy="Dr.", Address= "908 W. Capital Way" , HireDate = new DateTime(1992,08,14) }
        );

    context.SaveChanges();
    Console.WriteLine("Success saved!");
}
