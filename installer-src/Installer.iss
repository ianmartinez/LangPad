; -- Example1.iss --
; Installer for LangPad

[Setup]
AppName=LangPad
AppVersion=11.0
WizardStyle=modern
DefaultDirName={autopf}\LangPad
DefaultGroupName=LangPad
Compression=lzma2
SolidCompression=yes
ChangesAssociations = yes

[Files]                            
Source: "..\release\11.0 Beta\AutoUpdater.NET.dll"; DestDir: "{app}";   
Source: "..\release\11.0 Beta\FileIcon.ico"; DestDir: "{app}";
Source: "..\release\11.0 Beta\LangPad.exe"; DestDir: "{app}";       
Source: "..\release\11.0 Beta\LangPad.exe.config"; DestDir: "{app}"; 
Source: "..\release\11.0 Beta\LangPad.exe.manifest"; DestDir: "{app}"; 
Source: "..\release\11.0 Beta\LangPadSupport.dll"; DestDir: "{app}"; 
Source: "..\release\11.0 Beta\RtfPipe.dll"; DestDir: "{app}";   

[Icons]
Name: "{group}\LangPad"; Filename: "{app}\LangPad.exe"

[Registry]

Root: HKCR; Subkey: ".mpl"; ValueData: "{#LangPad}"; Flags: uninsdeletevalue; ValueType: string; ValueName: ""
Root: HKCR; Subkey: "{#LangPad}"; ValueData: "Program {#LangPad}";  Flags: uninsdeletekey; ValueType: string; ValueName: ""
Root: HKCR; Subkey: "{#LangPad}\DefaultIcon"; ValueData: "{app}\{#LangPad.exe},0"; ValueType: string; ValueName: ""
Root: HKCR; Subkey: "{#LangPad}\shell\open\command"; ValueData: """{app}\{#LangPad.exe}"" ""%1"""; ValueType: string; ValueName: ""