using System;
using MDispatch.iOS.NewRender.TextIn;
using Xamarin.Forms;
using Xfx;
using Xfx.Controls.iOS.Renderers;

[assembly: ExportRenderer(typeof(XfxEntry), typeof(CustomXfxEntryRendererTouch))]
namespace MDispatch.iOS.NewRender.TextIn
{
    public class CustomXfxEntryRendererTouch : XfxEntryRendererTouch
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                SetElement(null); //trigger elementchange before base dispose happens https://github.com/XamFormsExtended/Xfx.Controls/issues/97
            }

            base.Dispose(disposing);
        }
    }
}
