# PusshCap
Simple command line exe to capture screenshots.

There is a compiled 64 bit exe for convenience.

Captures the screen that the mouse cursor is on to the file specified as the only command line argument. If there are no args, it will save to 'cap.png' in the same directory as the exe. Always saves as PNG.

Outputs one line to stdout. A comma separated list of useful info about the screen of which the shot was taken:

screen-bounds-x,screen-bounds-y,screen-bounds-width,screen-bounds-height,mouse-x,mouse-y,filename-or-path

The screen bounds are taken directly from a .NET rectangle and are relative to the main screen. They can be negative, depending on screen orientation.

https://msdn.microsoft.com/en-us/library/system.drawing.rectangle%28v=vs.110%29.aspx 

MIT License

