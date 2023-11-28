using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockGestion
{
    public class RequestException:Exception
    {

        public RequestException():base()
        {

        }

        public RequestException(string msg) : base(msg)
        {

        }

    }
}
