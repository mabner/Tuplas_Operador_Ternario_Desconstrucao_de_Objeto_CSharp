using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuplas_Operador_Ternario_Desconstrucao_de_Objeto_CSharp.Models
{
    public class Person
    {
        public Person() { }

        public Person(string name, string surname)
        {
            Name = name.Trim();
            Surname = surname.Trim();
        }

        public void Deconstruct(out string name, out string surname)
        {
            name = Name;
            surname = Surname;
        }

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("The name field must not be empty.");
                }

                _name = value;
            }
        }
        public string Surname { get; set; }
    }
}
