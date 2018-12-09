using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorParallax.ViewModels
{
    public class FocalLengthViewModel
    {
        public int FocalLength { get; set; }

        public int Offset { get; set; }

        [JSInvokable]
        public void ModifyFocalLength(int focalLength)
        {
            FocalLength = focalLength;
        }
    }
}
