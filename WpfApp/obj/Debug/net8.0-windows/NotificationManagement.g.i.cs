﻿#pragma checksum "..\..\..\NotificationManagement.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41212A7173149A7C44F95BF2683031C6A29D16D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WpfApp;


namespace WpfApp {
    
    
    /// <summary>
    /// NotificationManagement
    /// </summary>
    public partial class NotificationManagement : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\NotificationManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitleTextBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\NotificationManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TitlePlaceholder;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\NotificationManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ContentTextBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\NotificationManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ContentPlaceholder;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\NotificationManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DepartmentComboBox;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\NotificationManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DepartmentIdPlaceholder;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\NotificationManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgNotifications;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp;component/notificationmanagement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\NotificationManagement.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\NotificationManagement.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackToHome_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TitleTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\NotificationManagement.xaml"
            this.TitleTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\NotificationManagement.xaml"
            this.TitleTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\NotificationManagement.xaml"
            this.TitleTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TitlePlaceholder = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.ContentTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\NotificationManagement.xaml"
            this.ContentTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 45 "..\..\..\NotificationManagement.xaml"
            this.ContentTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\NotificationManagement.xaml"
            this.ContentTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ContentPlaceholder = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.DepartmentComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 64 "..\..\..\NotificationManagement.xaml"
            this.DepartmentComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DepartmentComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DepartmentIdPlaceholder = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            
            #line 85 "..\..\..\NotificationManagement.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddNotification_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 86 "..\..\..\NotificationManagement.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateNotification_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 87 "..\..\..\NotificationManagement.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteNotification_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.dgNotifications = ((System.Windows.Controls.DataGrid)(target));
            
            #line 96 "..\..\..\NotificationManagement.xaml"
            this.dgNotifications.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgNotifications_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

