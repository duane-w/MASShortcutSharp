using System;
using System.Drawing;
using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;
using Shortcut;

[assembly: MonoMac.RequiredFramework("MASShortcut.dylib")]
namespace MASShortcutSharp
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		MainWindowController mainWindowController;
		
		public AppDelegate ()
		{
			Type t = typeof(MASShortcut);
			MonoMac.ObjCRuntime.Runtime.RegisterAssembly(t.Assembly); 
		}

		public override void FinishedLaunching (NSObject notification)
		{
			mainWindowController = new MainWindowController ();
			mainWindowController.Window.MakeKeyAndOrderFront (this);
		}
	}
}

