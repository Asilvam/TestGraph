using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestGraph.GraphQL.Types;
using TestGraph.Models;

namespace TestGraph.GraphQL.Queries
{
    public class productoquery: ObjectGraphType
    {
        private readonly modelContext _context;
        public productoquery(modelContext context)
        {
            this._context = context;
            Field<ListGraphType<productotype>>(
                "Productos",
                arguments: new QueryArguments(new List<QueryArgument>
                {
                    new QueryArgument<IdGraphType>
                    {
                        Name="id"
                    }
                }),
                resolve: context =>
                {
                    var ProductId = context.GetArgument<int?>("id");
                    if (ProductId.HasValue)
                    {
                        var res = _context.Products.Where(l => l.ProductId == ProductId).ToListAsync();
                        return res;
                    }
                    return _context.Products.ToListAsync();
                }
                );
        }
    }
}
