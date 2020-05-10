; Installer for LangPad

#define AppName "LangPad"
#define FileIcon "FileIcon.ico"
 
; Versioning
#define AppVersionType "_Beta"
#define AppVersion "11.0"   
#define AppVersionStr "11_0"   
#define AppReleaseFolder "..\release\11.0 Beta"

[Setup]
AppId={{F5A132A7-7583-4EBE-8E45-B90D8BC79B19}
AppName={#AppName}
AppVersion={#AppVersion}
WizardStyle=modern
DefaultDirName={autopf}\{#AppName}
DisableProgramGroupPage=yes
Compression=lzma2
SolidCompression=yes
ChangesAssociations=yes
OutputBaseFilename={#AppName}_{#AppVersionStr}{#AppVersionType}_Setup
LicenseFile=..\License
DisableWelcomePage=no

; Set custom messages on welcome screen
[Messages]
WelcomeLabel1=Welcome to the setup wizard for {#AppName} {#AppVersion}.
WelcomeLabel2={#AppName} is a free and open-source word processor for linguistics.

; Files to copy into program files
[Files]                              
Source: "{#AppReleaseFolder}\{#FileIcon}"; DestDir: "{app}";
Source: "{#AppReleaseFolder}\{#AppName}.exe"; DestDir: "{app}";       
Source: "{#AppReleaseFolder}\{#AppName}.exe.config"; DestDir: "{app}"; 
Source: "{#AppReleaseFolder}\{#AppName}.exe.manifest"; DestDir: "{app}";    
Source: "{#AppReleaseFolder}\AutoUpdater.NET.dll"; DestDir: "{app}"; 
Source: "{#AppReleaseFolder}\HtmlAgilityPack.dll"; DestDir: "{app}"; 
Source: "{#AppReleaseFolder}\LangPadData.dll"; DestDir: "{app}"; 
Source: "{#AppReleaseFolder}\LangPadUI.dll"; DestDir: "{app}"; 
Source: "{#AppReleaseFolder}\RtfPipe.dll"; DestDir: "{app}";   

; Add to start menu
[Icons]
Name: "{autoprograms}\{#AppName}"; Filename: "{app}\{#AppName}.exe"   

; Assosiate the *.nt file extension with LangPad and give it a custom icon
[Registry]
Root: HKCR; Subkey: ".nt"; ValueData: "{#AppName}"; Flags: uninsdeletevalue; ValueType: string; ValueName: ""
Root: HKCR; Subkey: "{#AppName}"; ValueData: "{#AppName} Notebook";  Flags: uninsdeletekey; ValueType: string; ValueName: ""
Root: HKCR; Subkey: "{#AppName}\DefaultIcon"; ValueData: "{app}\{#FileIcon},0"; ValueType: string; ValueName: ""
Root: HKCR; Subkey: "{#AppName}\shell\open\command"; ValueData: """{app}\{#AppName}.exe"" ""%1"""; ValueType: string; ValueName: ""

; Allow the user to run the program after setup is complete
[Run]
Filename: "{app}\{#AppName}.exe"; Description: "{cm:LaunchProgram,{#StringChange(AppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

