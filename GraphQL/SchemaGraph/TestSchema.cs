using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestGraph.GraphQL.Queries;

namespace TestGraph.GraphQL.SchemaGraph
{
    public class TestSchema:Schema
    {
        public TestSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<productoquery>();
        }
    }
}
