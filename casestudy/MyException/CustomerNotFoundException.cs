using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy.MyException
{
    internal class CustomerNotFoundException:ApplicationException
    {
        public CustomerNotFoundException(String msg) : base(msg)
        {

        }

    }
}
