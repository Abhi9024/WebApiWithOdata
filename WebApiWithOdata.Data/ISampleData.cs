using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiWithOdata.Data
{
    public interface ISampleData
    {
        List<Person> GetPersonsList();
    }
}
