﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    abstract class Animal
    {
        private string name;
        private int age;
        private GenderType gender;

        public Animal(string name, int age, GenderType gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
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

        public GenderType Gender
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
    }
}
