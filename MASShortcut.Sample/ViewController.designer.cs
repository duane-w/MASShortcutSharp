// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MASShortcut.Sample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton EnableF1 { get; set; }

		[Outlet]
		AppKit.NSButton EnableF2 { get; set; }

		[Outlet]
		AppKit.NSTextField Label { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (EnableF1 != null) {
				EnableF1.Dispose ();
				EnableF1 = null;
			}

			if (EnableF2 != null) {
				EnableF2.Dispose ();
				EnableF2 = null;
			}

			if (Label != null) {
				Label.Dispose ();
				Label = null;
			}
		}
	}
}
