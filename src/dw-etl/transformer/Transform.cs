using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using dw.common.util;

namespace dw.etl.transformer
{
    public class Transformer : AbstractTransformer, ITransformer
    {
        public delegate void TransformEventHandler(DataRow dataRow);

        public event TransformEventHandler TransformEvent;

        public Transformer(Arguments args):base(args)
        {

        }

        public Transformer() 
        {

        }

        public  override DataTable transform(DataTable data)
        {
            if (TransformEvent != null)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    DataRow r = data.Rows[i];

                    int n = 0;
                                  
                    foreach( TransformEventHandler te in TransformEvent.GetInvocationList())
                    {
                        Console.WriteLine("Calling " + i.ToString() + ":" + n.ToString() );
                        te(r);
                        n++;
                    }

                    Console.WriteLine("first_name: " + r["first_name"].ToString());

                    r.AcceptChanges();
                }
            }

            data.AcceptChanges();

            return data;
        }
    }
}
