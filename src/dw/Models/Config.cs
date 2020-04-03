using System;
using System.Collections.Generic;

namespace dw.Models
{
    public partial class Config
    {
        public Config()
        {
            ConfigParam = new HashSet<ConfigParam>();
        }

        public int ConfigId { get; set; }
        public string ConfigType { get; set; }
        public string ConfigName { get; set; }

        public virtual ICollection<ConfigParam> ConfigParam { get; set; }
    }
}
