MASShortcutSharp
================

C# bindings for MASShortcut
https://github.com/trustme/MASShortcut

A sample C# Xamarin.Mac and MonoMac project to use MASShortcut bindings.
MASShortcut is a modern framework for managing global keyboard shortcuts compatible with Mac App Store. 

See the sample for how to add the MASShortcut.dylib to your MonoMac application.

For use with Xamarin.Mac Compile the bindings with:
/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/usr/bin/bmac masshortcut.cs -s=Extras.cs -r:System.Drawing.dll --outdir=xamarin -baselib=/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/usr/lib/mono/XamMac.dll

For use with MonoMac Compile the bindings with:
mono bmac.exe masshortcut.cs -s=Extras.cs -d=MONOMAC -r:System.Drawing.dll --outdir=monomac
