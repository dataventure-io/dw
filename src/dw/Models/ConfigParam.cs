using System;
using System.Collections.Generic;

namespace dw.Models
{
    public partial class ConfigParam
    {
        public int ConfigParamId { get; set; }
        public int? ConfigId { get; set; }
        public string ParamName { get; set; }
        public string ParamValue { get; set; }

        public virtual Config Config { get; set; }
    }
}
