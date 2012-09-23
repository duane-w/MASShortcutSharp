// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;

namespace MASShortcutSharp
{
	[Register ("MainWindow")]
	partial class MainWindow
	{
		[Outlet]
		MonoMac.AppKit.NSTextField infoText { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton enableF2 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton enableF1 { get; set; }

		[Action ("onEnableF1:")]
		partial void onEnableF1 (MonoMac.Foundation.NSObject sender);

		[Action ("onEnableF2:")]
		partial void onEnableF2 (MonoMac.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (infoText != null) {
				infoText.Dispose ();
				infoText = null;
			}

			if (enableF2 != null) {
				enableF2.Dispose ();
				enableF2 = null;
			}

			if (enableF1 != null) {
				enableF1.Dispose ();
				enableF1 = null;
			}
		}
	}

	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		MonoMac.AppKit.NSTextField shortcutInfo { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (shortcutInfo != null) {
				shortcutInfo.Dispose ();
				shortcutInfo = null;
			}
		}
	}
}
