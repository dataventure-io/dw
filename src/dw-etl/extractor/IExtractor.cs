using System.Data;
using dw.common.util;

namespace dw.etl.extractor
{
    public interface IExtractor : IArguments
    {
        DataTable extract();
    }
}