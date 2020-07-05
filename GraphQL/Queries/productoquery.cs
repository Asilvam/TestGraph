using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestGraph.Models;

namespace TestGraph.GraphQL.Queries
{
    public class productoquery: ObjectGraphType
    {
        private readonly modelContext context;
        public productoquery(modelContext context)
        {
            this.context = context;

        }
    }
}
