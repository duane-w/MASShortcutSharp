MASShortcutSharp
================

C# bindings for MASShortcut
https://github.com/trustme/MASShortcut

A sample C# MonoMac project to use MASShortcut bindings.
MASShortcut is a modern framework for managing global keyboard shortcuts compatible with Mac App Store. 

See the sample for how to add the MASShortcut.dylib to your MonoMac application.

Compile the bindings with:
mono bmac.exe masshortcut.cs -s=Extras.cs -d=MONOMAC -r:System.Drawing.dll --outdir=monomac
