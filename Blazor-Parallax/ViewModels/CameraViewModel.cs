using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorParallax.ViewModels
{
    public class CameraViewModel
    {
        public string CameraModel { get; set; }

        public List<LenseViewModel> Lenses { get; set; }

        [JSInvokable]
        public void ModifyModel (string cameraModel)
        {
            CameraModel = cameraModel;
        }
    }
}
