﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiWithOdata.Data
{
    public class SampleData : ISampleData
    {
        static List<Person> persons = new List<Person>()
        {
            new Person(){ Id =1, Age=40,Name="I", Nation= Country.US },
            new Person(){ Id =2, Age=30,Name="Bangaram", Nation= Country.UK },
            new Person(){ Id =3, Age=60,Name="Monika", Nation= Country.India },
            new Person(){ Id =4, Age=50,Name="Love", Nation= Country.China },
            new Person(){ Id =5, Age=20,Name="You", Nation= Country.India },
            new Person(){ Id =6, Age=10,Name="Sweetheart", Nation= Country.Germany }
        };
        private List<Person> _persons;

        public SampleData()
        {
            _persons = persons;
        }

        public List<Person> GetPersonsList()
        {
            return this._persons;
        }
    }
}
