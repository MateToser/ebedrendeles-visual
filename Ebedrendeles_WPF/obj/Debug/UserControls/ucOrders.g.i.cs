﻿#pragma checksum "..\..\..\UserControls\ucOrders.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D201AC94BB38363BD95EB7531B931874"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ebedrendeles_WPF.UserControls;
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


namespace Ebedrendeles_WPF.UserControls {
    
    
    /// <summary>
    /// ucOrders
    /// </summary>
    public partial class ucOrders : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\UserControls\ucOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgOrders;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\UserControls\ucOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btDeleteOrder;
        
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
            System.Uri resourceLocater = new System.Uri("/Ebedrendeles_WPF;component/usercontrols/ucorders.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\ucOrders.xaml"
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
            this.dgOrders = ((System.Windows.Controls.DataGrid)(target));
            
            #line 15 "..\..\..\UserControls\ucOrders.xaml"
            this.dgOrders.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.dgOrders_MouseDown);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\UserControls\ucOrders.xaml"
            this.dgOrders.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgOrders_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btDeleteOrder = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\UserControls\ucOrders.xaml"
            this.btDeleteOrder.Click += new System.Windows.RoutedEventHandler(this.btDeleteOrder_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
