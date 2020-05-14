﻿#pragma checksum "..\..\Director.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F796724968404CC59AF097D046B3371401888E9CD92707154D1F81CF6FC8B5C2"
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
    /// Director
    /// </summary>
    public partial class Director : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Director.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TableIngredients;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Director.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TableOrders;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Director.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CommonTable;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Director.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Income;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Director.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Expenses;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Director.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CommonIncome;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Director.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CommonExpenses;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Director.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Date;
        
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
            System.Uri resourceLocater = new System.Uri("/CurseWork;component/director.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Director.xaml"
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
            this.TableIngredients = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.TableOrders = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.CommonTable = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.Income = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Expenses = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.CommonIncome = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.CommonExpenses = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Date = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\Director.xaml"
            this.Date.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Date_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 53 "..\..\Director.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Statistic_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 54 "..\..\Director.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AllFood_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 55 "..\..\Director.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FoodInMenu_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 56 "..\..\Director.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NeedForIngredients_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
