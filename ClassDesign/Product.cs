using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDesign;

public class Product
{
    public required string Name { get; init; }
    public required int Quantity { get; init; }
    public required decimal Price { get; init; }

    // Todo#1: create computed property "TotalPrice" as decimal
    public decimal TotalPrice => Quantity * Price;

    // Todo#2: override ToString()
    public override string ToString()
    {
        return $"Product: {Name}, Quantity: {Quantity}, Price: {Price:C}, Total: {TotalPrice:C}";
    }
}
