; -- Example1.iss --
; Demonstrates copying 3 files and creating an icon.

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!

[Setup]
AppName=Language Pad
AppVersion=10.0
WizardStyle=modern
DefaultDirName={autopf}\My Program
DefaultGroupName=LanguagePad
Compression=lzma2
SolidCompression=yes

[Files]
Source: "LanaugagePad.exe"; DestDir: "{app}"
Source: "MyProg.chm"; DestDir: "{app}"
Source: "Readme.txt"; DestDir: "{app}"; Flags: isreadme

[Icons]
Name: "{group}\Language Page"; Filename: "{app}\MyProg.exe"
