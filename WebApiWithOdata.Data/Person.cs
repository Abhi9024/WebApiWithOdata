﻿using System;

namespace WebApiWithOdata.Data
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Country Nation { get; set; }
    }
}
