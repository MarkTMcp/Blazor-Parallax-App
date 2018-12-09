using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorParallax.ViewModels
{
    public class LenseViewModel
    {
        public string LenseModel { get; set; }

        public List<FocalLengthViewModel> FocalLength { get; set; }

        [JSInvokable]
        public void ModifyModel(string lenseModel)
        {
            LenseModel = lenseModel;
        }
    }
}
