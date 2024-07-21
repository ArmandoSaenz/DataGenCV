using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenCV.Models
{
    public class SettingsValues
    {
        public int RMin { get; set; } = 0;
        public int RMax { get; set; } = 255;
        public int GMin { get; set; } = 0;
        public int GMax { get; set; } = 255;
        public int BMin { get; set; } = 0;
        public int BMax { get; set; } = 255;
        public int Area1 { get; set; } = 10;
        public int Area2 { get; set; } = 10;
    }
}
