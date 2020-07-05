using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestGraph.Models;

namespace TestGraph.GraphQL.Types
{
    public class usuariotype : ObjectGraphType<Usuario>
    {
        public usuariotype()
        {
            Name = "Usuario";
            Field(x => x.Id);
            Field(x => x.Nombre);
            Field(x => x.Apellido);
            Field(x => x.Edad);

        }

            
    }
}
