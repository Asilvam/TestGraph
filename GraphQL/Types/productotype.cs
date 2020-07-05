using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestGraph.Models;

namespace TestGraph.GraphQL.Types
{
    public class productotype:ObjectGraphType<Products>
    {
        public productotype()
        {
            Name = "Producto";
            Field(x => x.ProductId);
            Field(x => x.ProductName).Description("Nombre de producto");
            Field(x => x.ProductDescription);
            Field(x => x.Price);
        }
    }
}
