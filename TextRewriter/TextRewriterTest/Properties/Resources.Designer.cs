﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TextRewriterTest.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TextRewriterTest.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Lp.: 1.
        ///Przedmiot zamówienia: Bułka tarta wrocł. 0,5 kg
        ///Jednostka miary: szt
        ///Ilość szacunkowa: 90
        ///Lp.: 2.
        ///Przedmiot zamówienia: Budyń „Winiary” 1,30 kg
        ///Jednostka miary: szt
        ///Ilość szacunkowa: 12
        ///Lp.: 3.
        ///Przedmiot zamówienia: Biszkopty wrocławskie
        ///Jednostka miary: szt
        ///Ilość szacunkowa: 70
        ///.
        /// </summary>
        internal static string TableRewriterTest1Expected {
            get {
                return ResourceManager.GetString("TableRewriterTest1Expected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lp.  	Przedmiot zamówienia 	Jednostka miary 	Ilość szacunkowa
        ///1.	Bułka tarta wrocł. 0,5 kg	szt	90				
        ///2.	Budyń „Winiary” 1,30 kg	szt	12				
        ///3.	Biszkopty wrocławskie	szt	70.
        /// </summary>
        internal static string TableRewriterTest1Text {
            get {
                return ResourceManager.GetString("TableRewriterTest1Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nazwa asortymentu: Cukier
        ///j.m.: kg
        ///Ilość szacun.: 1200
        ///Nazwa asortymentu: Mąka wrocławska
        ///j.m.: kg
        ///Ilość szacun.: 600
        ///Nazwa asortymentu: Mąka ziemniaczana
        ///j.m.: kg
        ///Ilość szacun.: 60
        ///.
        /// </summary>
        internal static string TableRewriterTest2Expected {
            get {
                return ResourceManager.GetString("TableRewriterTest2Expected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nazwa asortymentu	j.m.	Ilość szacun.
        ///Cukier	kg	1200
        ///Mąka wrocławska	kg	600
        ///Mąka ziemniaczana	kg	60.
        /// </summary>
        internal static string TableRewriterTest2Text {
            get {
                return ResourceManager.GetString("TableRewriterTest2Text", resourceCulture);
            }
        }
    }
}