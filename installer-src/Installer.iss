; -- Example1.iss --
; Installer for LangPad

[Setup]
AppName=LangPad
AppVersion=10.1
WizardStyle=modern
DefaultDirName={autopf}\LangPad
DefaultGroupName=LangPad
Compression=lzma2
SolidCompression=yes

[Files]                            
Source: "app\AutoUpdater.NET.dll"; DestDir: "{app}";  
Source: "app\LangPad.exe"; DestDir: "{app}";       
Source: "app\LangPad.exe.config"; DestDir: "{app}"; 
Source: "app\LangPad.exe.manifest"; DestDir: "{app}";  
Source: "app\RtfPipe.dll"; DestDir: "{app}";   
Source: "app\TundraLib.dll"; DestDir: "{app}";

[Icons]
Name: "{group}\LangPad"; Filename: "{app}\LangPad.exe"
