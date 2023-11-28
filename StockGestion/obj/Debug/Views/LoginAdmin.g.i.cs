﻿#pragma checksum "..\..\..\Views\LoginAdmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6E8F4B6A7331EE7220359365FB78B525217000E995D86115833BC4100D0C3CB8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using StockGestion.Views;
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


namespace StockGestion.Views {
    
    
    /// <summary>
    /// LoginAdmin
    /// </summary>
    public partial class LoginAdmin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Views\LoginAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon icon;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\LoginAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mailAdmin;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Views\LoginAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox MDPAdmin;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Views\LoginAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button admin_connect;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Views\LoginAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button admin_retour;
        
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
            System.Uri resourceLocater = new System.Uri("/StockGestion;component/views/loginadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\LoginAdmin.xaml"
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
            this.icon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 2:
            this.mailAdmin = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\..\Views\LoginAdmin.xaml"
            this.mailAdmin.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.mailAdmin_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MDPAdmin = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 81 "..\..\..\Views\LoginAdmin.xaml"
            this.MDPAdmin.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.MDPAdmin_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.admin_connect = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\Views\LoginAdmin.xaml"
            this.admin_connect.Click += new System.Windows.RoutedEventHandler(this.admin_connect_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.admin_retour = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\Views\LoginAdmin.xaml"
            this.admin_retour.Click += new System.Windows.RoutedEventHandler(this.admin_retour_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

