﻿#pragma checksum "..\..\Basket.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "21A52051E6524B7BA157F630756D27840FAB7F60B00AE87EA073C6051FB074DD"
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
    /// Basket
    /// </summary>
    public partial class Basket : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Basket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid BasketTable;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Basket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AllSum;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Basket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Delete;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Basket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MiddleName;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Basket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstName;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Basket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastName;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Basket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Telephone;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Basket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteFromBasket;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Basket.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Buy;
        
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
            System.Uri resourceLocater = new System.Uri("/CurseWork;component/basket.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Basket.xaml"
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
            this.BasketTable = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.AllSum = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Delete = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.MiddleName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.FirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.LastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Telephone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.DeleteFromBasket = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\Basket.xaml"
            this.DeleteFromBasket.Click += new System.Windows.RoutedEventHandler(this.DeleteFromBasket_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Buy = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Basket.xaml"
            this.Buy.Click += new System.Windows.RoutedEventHandler(this.Buy_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

