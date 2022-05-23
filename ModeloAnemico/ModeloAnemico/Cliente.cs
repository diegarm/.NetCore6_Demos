using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloAnemico
{
    //Sealed cannot be inherited
    public sealed class Cliente
    {
        public Cliente(Guid id, string name, string lastName)
        {
            Validate(id, name, lastName);
            Id = id;
            Name = name;
            LastName = lastName;
        }

        private void Validate(Guid id, string name, string lastName)
        {
            if(name == null || name.Length < 3)
            {
                throw new InvalidOperationException("The name is required and must be greater than 3");
            }
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public string LastName { get; private set; }
        


        

    }
}
