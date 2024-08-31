using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{

    class DataBase
    {
        public void ConnectDb()
        {

        }
        public void DisConnectDb()
        {

        }

        public List<Person> GetPersons()
        {
            return new()
            {
                new(){Name="",Surname=""}
            };
        }
    }
}
