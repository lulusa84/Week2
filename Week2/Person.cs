using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public class Person : IComparable

    {
        private string _firstName;
        public Document Document { get; set; }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value == "")
                {
                    _firstName = "John";
                }
                else
                {
                    _firstName = value;
                }
            }
        }

        public string Name { get; set; } = "John";
        public String FullName

        {
            get
            {
                return Name + " " + FirstName;

            }

        }

        public DateTime DateBirth { get; }

        public int Age
        {
            get
            {
                return CalculateAge();
            }
        }

        private int CalculateAge()
        {
            return DateTime.Today.Year - DateBirth.Year;

        }

        #region OBJECT METHODS 

        public override string ToString()
        {
            return $"{FullName} - {Age}";
        }


        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Person p = (Person)obj;
                return this.FullName.Equals(p.FullName);
            }
        }
        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepClone()
        {
            Person other = (Person)this.MemberwiseClone();
            other.Document = new Document(this.Document.IdNumber);
            return other;

        }
        #endregion

        #region METHODS

        //PARAMETRO OPZIONALE
        public string Description(string prefix = "Mr.")
        {
            return $"{prefix} {FullName}";
        }

        public void PrintFamily(string title, params Person[] family)
        {
            Console.WriteLine($"=={title} ==");
            foreach (Person p in family)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine(FamilySecret());
        }

        //Accessibile solo dala classe Person
        private string FamilySecret()
        {
            return "Questo è un segreto di famiglia";
        }

        public PersonResponse CheckAgePerson(PersonRequest pr)
        {
            if (pr.Age < 0)
            {
                return new PersonResponse
                {
                    Success = false,
                    Errore = "Età < 0",
                    ReturnedValue = null
                };

            }
            return new PersonResponse
            {
                Success = true,
                Errore = "",
                ReturnedValue = new Person
                {
                    Name = pr.Name,
                    FirstName = pr.Surname
                }
            };
            
        }

        //TUPLA
        public (bool Success, String Errore, Person ReturnedValue)
            CheckAgePersonTupla(PersonRequest pr)
        {
            if (pr.Age < 0)
            {
                return (false, "età < di 0", null);
            }
            return (true,
                "",
                new Person
                {
                    Name = pr.Name,
                    FirstName = pr.Surname
                });

        }

        public bool CheckAgePersonOut(PersonRequest pr, out string errore,  out Person value)
        {
            if(pr.Age < 0)
            {
                errore = "Età < 0";
                value = null;
                return false;
            }
            else
            {
                errore = "";
                value =
                    new Person
                    {
                        Name = pr.Name,
                        FirstName = pr.Surname
                    };
                return true;
            };
        }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}