// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace HolaIOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton botonContar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelResultado { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (botonContar != null) {
                botonContar.Dispose ();
                botonContar = null;
            }

            if (labelResultado != null) {
                labelResultado.Dispose ();
                labelResultado = null;
            }
        }
    }
}