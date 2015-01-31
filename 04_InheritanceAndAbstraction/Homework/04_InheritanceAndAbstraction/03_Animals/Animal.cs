using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    abstract class Animal : ISound
    {
        private string name;
        private int age;
        private GenderType.Gender gender;

        public Animal(string name, int age, GenderType.Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public GenderType.Gender Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public abstract void ProduceSound();

        public override string ToString()
        {
            return String.Format("Name: {0}; Age: {1}", this.Name, this.Age);
        }
    }
}
