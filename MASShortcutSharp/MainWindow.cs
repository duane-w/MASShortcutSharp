
using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;
using Shortcut;

namespace MASShortcutSharp
{
	public partial class MainWindow : MonoMac.AppKit.NSWindow
	{
		#region Constructors
		
		// Called when created from unmanaged code
		public MainWindow (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public MainWindow (NSCoder coder) : base (coder)
		{
			Initialize ();
		}
		
		// Shared initialization code
		void Initialize ()
		{
		}
		
		#endregion

		NSObject f1Shortcut = null;
		NSObject f2Shortcut = null;

		partial void onEnableF1 (NSObject sender)
		{
			if (f1Shortcut == null)
			{
				enableF1.Title = "Disable Cmd-F1";
				infoText.StringValue = "Cmd-F1 is enabled";
				MASShortcut shortcut1 = new MASShortcut(Keycode.kVK_F1, EventModifier.NSCommandKeyMask);
				f1Shortcut = MASShortcut.AddGlobalHotkeyMonitor(shortcut1,
				delegate {
					infoText.StringValue = "Cmd-F1 pressed";
				});
			}
			else
			{
				enableF1.Title = "Enable Cmd-F1";
				infoText.StringValue = "Cmd-F1 is disabled";
				MASShortcut.RemoveGlobalHotkeyMonitor(f1Shortcut);
				f1Shortcut = null;
			}
		}

		partial void onEnableF2 (NSObject sender)
		{
			if (f2Shortcut == null)
			{
				enableF2.Title = "Disable Cmd-F2";
				infoText.StringValue = "Cmd-F2 is enabled";
				MASShortcut shortcut2 = new MASShortcut(Keycode.kVK_F2, EventModifier.NSCommandKeyMask);
				f2Shortcut = MASShortcut.AddGlobalHotkeyMonitor(shortcut2, callback);
			}
			else
			{
				enableF2.Title = "Enable Cmd-F2";
				infoText.StringValue = "Cmd-F2 is disabled";
				MASShortcut.RemoveGlobalHotkeyMonitor(f2Shortcut);
				f2Shortcut = null;
			}
		}

		public void callback()
		{
			infoText.StringValue = "Cmd-F2 pressed";
		}
	}
}

