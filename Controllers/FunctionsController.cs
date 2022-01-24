using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5101_A1_W2021.Controllers
{
    public class AddTenController : ApiController
    {
        public int GET(int id)
        {
            // id = /api/addten/THISNUMBER
            int total = id + 10;
            return total;
        }
    }

    public class SquareController : ApiController
    {
        public int GET(int id)
        {
            // id = /api/squared/THISNUMBER
            int total = id * id;
            return total;
        }
    }

    public class GreetingController : ApiController
    {
        public string GET()
        {
            return "Hello World!";
        }

        public string GET(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }

    public class NumberMachineController : ApiController
    {
        public int GET(int id)
        {
            // perform 4 different mathematical operations, starting with the id
            int addition = id + 6;
            int division = addition / 4;
            int subtraction = division - 2;
            int multiplication = subtraction * 7;

            // set the total as the result of the final operation
            int total = multiplication;

            return total;
        }
    }
}
