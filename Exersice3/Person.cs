using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice3
{
    internal class Person
    {
        private int age;
        private string fname;
        private string lname;
        private double height;
        private double weight;



        //gettters and setters
        #region



        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    throw new ArgumentException($"You are trying to set the age of {fname}. The age is not acceptable");
                    
                }

            }
        }



        public string Fname
        {
            get 
            { 
                return fname; 
            }
            set
            { 
                if((value.Length > 2) && (value.Length < 11))

                { 
                    fname = value; 
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (value.Length < 2)
                    {
                        throw new ArgumentException($"You are trying to set the First name of {fname}. First Name too short");
                    }
                    else if (value.Length > 10)
                    {
                        throw new ArgumentException($"You are trying to set the First name of {fname}.First Name too Long");
                    }
                   
                }
                
            }
        }
        
        public string Lname
        {
            get { return lname; }

            set
            {
                if ((value.Length > 3) && (value.Length < 16))
                { lname = value; }


                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (value.Length < 3)
                    {
                        Console.WriteLine($"You are trying to set the Last name of {fname}. Last Name too short");
                    }
                    else if (value.Length > 15)
                    {
                        Console.WriteLine($"You are trying to set the Last name of {fname}. Last Name too Long");
                    }
                    throw new ArgumentException();
                }
            }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        #endregion

        //Konstruktor
        public Person(int age, string fname, string lname, double height, double weight )
        {
            
            Age = age;  
            Fname = fname;  
            Lname = lname;
            Height = height;
            Weight = weight;
            Console.WriteLine($"The person {fname} was created");
        }



        public void PrintPerson()
        {
            Console.WriteLine($"Name: {fname} {lname}");
            Console.WriteLine($"Age: {age}\nHeight: { height} m\nWeight: {weight} kg");
        }
    }


}
