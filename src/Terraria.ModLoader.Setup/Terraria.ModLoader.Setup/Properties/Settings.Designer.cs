//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Terraria.ModLoader.Setup.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Setup.Properties.Settings defaultInstance = ((Setup.Properties.Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Setup.Properties.Settings())));
        
        public static Setup.Properties.Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TerrariaSteamDir {
            get {
                return ((string)(this["TerrariaSteamDir"]));
            }
            set {
                this["TerrariaSteamDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int PatchMode {
            get {
                return ((int)(this["PatchMode"]));
            }
            set {
                this["PatchMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool FormatAfterDecompiling {
            get {
                return ((bool)(this["FormatAfterDecompiling"]));
            }
            set {
                this["FormatAfterDecompiling"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("d05cf700a90fc12d7f9ef40f1d303b3a")]
        public string GoGClientWinMD5 {
            get {
                return ((string)(this["GoGClientWinMD5"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TMLDevSteamDir {
            get {
                return ((string)(this["TMLDevSteamDir"]));
            }
            set {
                this["TMLDevSteamDir"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("22e41c9960f3db473a036e93bbaec671")]
        public string SteamClientWinMD5 {
            get {
                return ((string)(this["SteamClientWinMD5"]));
            }
        }
    }
}