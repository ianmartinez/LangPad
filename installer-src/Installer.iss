; -- Example1.iss --
; Installer for LangPad

[Setup]
AppName=LangPad
AppVersion=10.1
WizardStyle=modern
DefaultDirName={autopf}\My Program
DefaultGroupName=LangPad
Compression=lzma2
SolidCompression=yes

[Files]

Source: "LangPad.exe"; DestDir: "{app}";

[Icons]
Name: "{group}\Language Page"; Filename: "{app}\MyProg.exe"
