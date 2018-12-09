using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorParallax.Models
{
    public class Setting
    {
        public string CameraModel { get; set; } 

        public string LenseModel { get; set; } 

        public int FocalLength { get; set; }

        public int Offset { get; set; }
    }
}
