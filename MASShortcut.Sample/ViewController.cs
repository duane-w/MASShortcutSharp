using System;

using AppKit;
using Foundation;

namespace MASShortcut.Sample
{
	public partial class ViewController : NSViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			EnableF1.Activated += (o, e) => OnEnableF1 ();
			EnableF2.Activated += (o, e) => OnEnableF2 ();
		}

		NSObject f1Shortcut;
		NSObject f2Shortcut;

		void OnEnableF1 ()
		{
			if (f1Shortcut == null) {
				EnableF1.Title = "Disable Cmd-F1";
				Label.StringValue = "Cmd-F1 is enabled";
				var shortcut1 = new Shortcut.MASShortcut ((uint)NSKey.F1, (uint)NSEventModifierMask.CommandKeyMask);
				f1Shortcut = Shortcut.MASShortcut.AddGlobalHotkeyMonitor (shortcut1, () => { Label.StringValue = "Cmd-F1 pressed"; });
			} else {
				EnableF1.Title = "Enable Cmd-F1";
				Label.StringValue = "Cmd-F1 is disabled";
				Shortcut.MASShortcut.RemoveGlobalHotkeyMonitor (f1Shortcut);
				f1Shortcut = null;
			}
		}

		void OnEnableF2 ()
		{
			if (f2Shortcut == null) {
				EnableF2.Title = "Disable Cmd-F2";
				Label.StringValue = "Cmd-F2 is enabled";
				var shortcut2 = new Shortcut.MASShortcut ((uint)NSKey.F2, (uint)NSEventModifierMask.CommandKeyMask);
				f2Shortcut = Shortcut.MASShortcut.AddGlobalHotkeyMonitor (shortcut2, () => { Label.StringValue = "Cmd-F2 pressed"; });
			} else {
				EnableF2.Title = "Enable Cmd-F2";
				Label.StringValue = "Cmd-F2 is disabled";
				Shortcut.MASShortcut.RemoveGlobalHotkeyMonitor (f2Shortcut);
				f2Shortcut = null;
			}
		}
	}
}
