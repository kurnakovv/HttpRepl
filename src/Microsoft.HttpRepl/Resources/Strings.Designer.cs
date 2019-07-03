﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.HttpRepl.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.HttpRepl.Resources.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;set base {url}&apos; must be called before issuing requests to a relative path.
        /// </summary>
        internal static string Error_NoBasePath {
            get {
                return ResourceManager.GetString("Error_NoBasePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot start the REPL when output is being redirected.
        /// </summary>
        internal static string Error_OutputRedirected {
            get {
                return ResourceManager.GetString("Error_OutputRedirected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arguments:.
        /// </summary>
        internal static string Help_Arguments {
            get {
                return ResourceManager.GetString("Help_Arguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to   {0} - The initial base address for the REPL..
        /// </summary>
        internal static string Help_BaseAddress {
            get {
                return ResourceManager.GetString("Help_BaseAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to   {0} - Show help information..
        /// </summary>
        internal static string Help_Help {
            get {
                return ResourceManager.GetString("Help_Help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Options:.
        /// </summary>
        internal static string Help_Options {
            get {
                return ResourceManager.GetString("Help_Options", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to REPL Commands:.
        /// </summary>
        internal static string Help_REPLCommands {
            get {
                return ResourceManager.GetString("Help_REPLCommands", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: .
        /// </summary>
        internal static string Help_Usage {
            get {
                return ResourceManager.GetString("Help_Usage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not have a configured value.
        /// </summary>
        internal static string PrefCommand_Error_NoConfiguredValue {
            get {
                return ResourceManager.GetString("PrefCommand_Error_NoConfiguredValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Whether to get or set a preference must be specified.
        /// </summary>
        internal static string PrefCommand_Error_NoGetOrSet {
            get {
                return ResourceManager.GetString("PrefCommand_Error_NoGetOrSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The preference to set must be specified.
        /// </summary>
        internal static string PrefCommand_Error_NoPreferenceName {
            get {
                return ResourceManager.GetString("PrefCommand_Error_NoPreferenceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error saving preferences.
        /// </summary>
        internal static string PrefCommand_Error_Saving {
            get {
                return ResourceManager.GetString("PrefCommand_Error_Saving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configured value: {0}.
        /// </summary>
        internal static string PrefCommand_Get_ConfiguredValue {
            get {
                return ResourceManager.GetString("PrefCommand_Get_ConfiguredValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current Preferences:.
        /// </summary>
        internal static string PrefCommand_HelpDetails_CurrentPreferences {
            get {
                return ResourceManager.GetString("PrefCommand_HelpDetails_CurrentPreferences", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current Default Preferences:.
        /// </summary>
        internal static string PrefCommand_HelpDetails_DefaultPreferences {
            get {
                return ResourceManager.GetString("PrefCommand_HelpDetails_DefaultPreferences", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} - Gets the value of the specified preference or lists all preferences if no preference is specified.
        /// </summary>
        internal static string PrefCommand_HelpDetails_GetSyntax {
            get {
                return ResourceManager.GetString("PrefCommand_HelpDetails_GetSyntax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} - Sets (or clears if value is not specified) the value of the specified preference.
        /// </summary>
        internal static string PrefCommand_HelpDetails_SetSyntax {
            get {
                return ResourceManager.GetString("PrefCommand_HelpDetails_SetSyntax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} - Get or sets a preference to a particular value.
        /// </summary>
        internal static string PrefCommand_HelpDetails_Syntax {
            get {
                return ResourceManager.GetString("PrefCommand_HelpDetails_Syntax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} - Allows viewing or changing preferences.
        /// </summary>
        internal static string PrefCommand_HelpSummary {
            get {
                return ResourceManager.GetString("PrefCommand_HelpSummary", resourceCulture);
            }
        }
    }
}
