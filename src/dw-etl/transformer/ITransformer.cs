using System.Data;
using dw.common.util;

namespace dw.etl.transformer
{
    public interface ITransformer : IArguments
    {
        DataTable transform( DataTable data);
    }
}