using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dw.common.util
{
    public class EtlException : Exception
    {
        public EtlException():base()
        {
        }

        public EtlException(string message):base(message)
        {
        }

        public EtlException(string message, Exception inner):base(message, inner)
        {
        }

        public EtlException(Type t, string message) : base(t.Name + ": " + message)
        {
        }

        public EtlException(Type t, string message, Exception inner) : base(t.Name + ": " + message, inner)
        {
        }
    }
}
