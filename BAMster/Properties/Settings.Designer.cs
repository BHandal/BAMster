﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BAMster.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("S:\\Research-Development\\NEXT GENERATION SEQUENCING\\tools\\BAMStats-1.25\\jar\\BAMSta" +
            "ts-GUI-1.25.jar")]
        public string bamstats_gui {
            get {
                return ((string)(this["bamstats_gui"]));
            }
            set {
                this["bamstats_gui"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("S:\\Research-Development\\NEXT GENERATION SEQUENCING\\tools\\BAMStats-1.25\\jar\\BAMSta" +
            "ts-API-1.25.jar")]
        public string bamstats_api {
            get {
                return ((string)(this["bamstats_api"]));
            }
            set {
                this["bamstats_api"] = value;
            }
        }
    }
}
