﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace L2.Net.CacheService.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public byte ServiceUniqueID {
            get {
                return ((byte)(this["ServiceUniqueID"]));
            }
            set {
                this["ServiceUniqueID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MsSql")]
        public global::L2.Net.DataProvider.SqlEngine SqlEngine {
            get {
                return ((global::L2.Net.DataProvider.SqlEngine)(this["SqlEngine"]));
            }
            set {
                this["SqlEngine"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=(local);user id=L2CacheServer;password=password;database=l2.net")]
        public string SqlServerConnectionString {
            get {
                return ((string)(this["SqlServerConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public byte SqlServerConnectionsPoolSize {
            get {
                return ((byte)(this["SqlServerConnectionsPoolSize"]));
            }
            set {
                this["SqlServerConnectionsPoolSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:01:00")]
        public global::System.TimeSpan SqlServerDumpInterval {
            get {
                return ((global::System.TimeSpan)(this["SqlServerDumpInterval"]));
            }
            set {
                this["SqlServerDumpInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string CacheServiceListenerAddress {
            get {
                return ((string)(this["CacheServiceListenerAddress"]));
            }
            set {
                this["CacheServiceListenerAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3001")]
        public int CacheServiceListenerPort {
            get {
                return ((int)(this["CacheServiceListenerPort"]));
            }
            set {
                this["CacheServiceListenerPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CacheServiceEnableFirewall {
            get {
                return ((bool)(this["CacheServiceEnableFirewall"]));
            }
            set {
                this["CacheServiceEnableFirewall"] = value;
            }
        }
    }
}
