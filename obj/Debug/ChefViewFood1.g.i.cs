﻿#pragma checksum "..\..\ChefViewFood1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "286C14FC77645FFD3F0BA4DA3B63DC6E1DCACEA66CD46A88DC3263F7E28A783F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CurseWork;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CurseWork {
    
    
    /// <summary>
    /// CurrentFood
    /// </summary>
    public partial class CurrentFood : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\ChefViewFood1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ChefViewFood1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Description;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ChefViewFood1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Structure;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ChefViewFood1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Recept;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ChefViewFood1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ChefViewFood1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Category;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ChefViewFood1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeImage;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ChefViewFood1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddFood;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ChefViewFood1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveChange;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CurseWork;component/chefviewfood1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChefViewFood1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Image = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.Description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Structure = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Recept = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Category = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ChangeImage = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\ChefViewFood1.xaml"
            this.ChangeImage.Click += new System.Windows.RoutedEventHandler(this.ChangeImage_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AddFood = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\ChefViewFood1.xaml"
            this.AddFood.Click += new System.Windows.RoutedEventHandler(this.AddFood_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SaveChange = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\ChefViewFood1.xaml"
            this.SaveChange.Click += new System.Windows.RoutedEventHandler(this.SaveChange_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
