
using MonoMac.Foundation;
using MonoMac.ObjCRuntime;
using MonoMac.AppKit;
using System;


namespace Shortcut
{

	delegate void GlobalHotkeyMonitorHandler ();

	//@interface MASShortcut (Monitoring)
	[BaseType (typeof (NSObject))]
	interface MASShortcut {

		//From Generated Property
		//@property (nonatomic) NSUInteger keyCode;
		[Export ("keyCode")]
		uint KeyCode { get; set;  }

		//@property (nonatomic) NSUInteger modifierFlags;
		[Export ("modifierFlags")]
		uint ModifierFlags { get; set;  }

		//@property (nonatomic, readonly) UInt32 carbonKeyCode;
		[Export ("carbonKeyCode")]
		UInt32 CarbonKeyCode { get;  }

		//@property (nonatomic, readonly) UInt32 carbonFlags;
		[Export ("carbonFlags")]
		UInt32 CarbonFlags { get;  }

		//@property (nonatomic, readonly) NSString *keyCodeString;
		[Export ("keyCodeString")]
		string KeyCodeString { get;  }

		//@property (nonatomic, readonly) NSString *keyCodeStringForKeyEquivalent;
		[Export ("keyCodeStringForKeyEquivalent")]
		string KeyCodeStringForKeyEquivalent { get;  }

		//@property (nonatomic, readonly) NSString *modifierFlagsString;
		[Export ("modifierFlagsString")]
		string ModifierFlagsString { get;  }

		//@property (nonatomic, readonly) NSData *data;
		[Export ("data")]
		NSData Data { get;  }

		//@property (nonatomic, readonly) BOOL shouldBypass;
		[Export ("shouldBypass")]
		bool ShouldBypass { get;  }

		//@property (nonatomic, readonly, getter = isValid) BOOL valid;
		[Export ("isValid")]
		bool Valid { get;  }

		//+ (id)addGlobalHotkeyMonitorWithShortcut:(MASShortcut *)shortcut handler:(void (^)())handler;
		[Static]
		[Export ("addGlobalHotkeyMonitorWithShortcut:handler:")]
		NSObject AddGlobalHotkeyMonitor (MASShortcut shortcut,GlobalHotkeyMonitorHandler _delegate);

		//+ (void)removeGlobalHotkeyMonitor:(id)monitor;
		[Static]
		[Export ("removeGlobalHotkeyMonitor:")]
		void RemoveGlobalHotkeyMonitor (NSObject monitor);

		//- (id)initWithKeyCode:(NSUInteger)code modifierFlags:(NSUInteger)flags;
		[Export ("initWithKeyCode:modifierFlags:")]
		IntPtr Constructor (Keycode code,EventModifier modifierFlags);

		//+ (MASShortcut *)shortcutWithKeyCode:(NSUInteger)code modifierFlags:(NSUInteger)flags;
		[Static]
		[Export ("shortcutWithKeyCode:modifierFlags:")]
		MASShortcut ShortcutWithKeyCode (uint code,uint modifierFlags);

		//+ (MASShortcut *)shortcutWithEvent:(NSEvent *)anEvent;
		[Static]
		[Export ("shortcutWithEvent:")]
		MASShortcut ShortcutWithEvent (NSEvent anEvent);

		//+ (MASShortcut *)shortcutWithData:(NSData *)aData;
		[Static]
		[Export ("shortcutWithData:")]
		MASShortcut ShortcutWithData (NSData aData);

		//- (BOOL)isTakenError:(NSError **)error;
		[Export ("isTakenError:")]
		bool IsTakenError (out NSError error);


	}
}
