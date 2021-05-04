using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data;

namespace Zoo.Data
{
    class AData
    {
        public string login;
        public string password;
        //public string post;
        public string CheckAData()
        {
            
            if (login == "dir" && password == "1234")
                return "director";
            if (login == "sotr" && password == "1234")
                return "sotr";
            if (login == "vet" && password == "1234")
                return "vet";

            return "none";
        }


    }
}
