using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy.MyException
{
    internal class OrderNotFoundException:ApplicationException
    {
        public OrderNotFoundException(String msg) : base(msg)
        {

        }
    }
}
