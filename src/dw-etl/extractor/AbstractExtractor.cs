using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using dw.common.util;

namespace dw.etl.extractor
{
    public class AbstractExtractor : IExtractor
    {
        protected Arguments arguments = null;

        public AbstractExtractor()
        {

        }

        public AbstractExtractor( Arguments arg)
        {
            setArgs(arg);
        }

        public virtual DataTable extract()
        {
            return null;
        }

        public void setArgs(Arguments arg)
        {
            this.arguments = arg;
        }
    }
}
