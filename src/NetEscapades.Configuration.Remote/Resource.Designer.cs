﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetEscapades.Configuration.Remote {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Resource() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NetEscapades.Configuration.Remote.Resource", typeof(Resource).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Error calling remote configuration endpoint: {0} - {1}.
        /// </summary>
        public static string Error_HttpError {
            get {
                return ResourceManager.GetString("Error_HttpError", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {0} must not end with &apos;{1}&apos;.
        /// </summary>
        public static string Error_InvalidEndCharacter {
            get {
                return ResourceManager.GetString("Error_InvalidEndCharacter", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to {0} must not start with &apos;{1}&apos;.
        /// </summary>
        public static string Error_InvalidStartCharacter {
            get {
                return ResourceManager.GetString("Error_InvalidStartCharacter", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Could not parse the JSON file. Error on line number &apos;{0}&apos;: &apos;{1}&apos;..
        /// </summary>
        public static string Error_JSONParseError {
            get {
                return ResourceManager.GetString("Error_JSONParseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to A duplicate key &apos;{0}&apos; was found..
        /// </summary>
        public static string Error_KeyIsDuplicated {
            get {
                return ResourceManager.GetString("Error_KeyIsDuplicated", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Unsupported JSON token &apos;{0}&apos; was found. Path &apos;{1}&apos;, line {2} position {3}..
        /// </summary>
        public static string Error_UnsupportedJSONToken {
            get {
                return ResourceManager.GetString("Error_UnsupportedJSONToken", resourceCulture);
            }
        }
    }
}