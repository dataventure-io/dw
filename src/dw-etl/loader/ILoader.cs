using System.Data;
using dw.common.util;

namespace dw.etl.loader
{
    public interface ILoader : IArguments
    {
        void load(DataTable data);
    }


}