﻿#pragma checksum "..\..\..\Views\UserPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FC31A5D29AE6490470AC1984B8EB3A9B118512671606798AC105FA894711036F"
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
    /// UserPage
    /// </summary>
    public partial class UserPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\Views\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon iconMenu;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Views\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button vente;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button prodFaible;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Views\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stock;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Views\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button quitter;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Views\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame PageInfoUser;
        
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
            System.Uri resourceLocater = new System.Uri("/StockGestion;component/views/userpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\UserPage.xaml"
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
            
            #line 9 "..\..\..\Views\UserPage.xaml"
            ((StockGestion.Views.UserPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.iconMenu = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 3:
            this.vente = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Views\UserPage.xaml"
            this.vente.Click += new System.Windows.RoutedEventHandler(this.vente_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.prodFaible = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Views\UserPage.xaml"
            this.prodFaible.Click += new System.Windows.RoutedEventHandler(this.prodFaible_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.stock = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\Views\UserPage.xaml"
            this.stock.Click += new System.Windows.RoutedEventHandler(this.stock_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.quitter = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\Views\UserPage.xaml"
            this.quitter.Click += new System.Windows.RoutedEventHandler(this.quitter_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PageInfoUser = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

