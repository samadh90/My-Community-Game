﻿#pragma checksum "..\..\..\Views\6_0_CommunauteView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F67EF9D12BCE3F9412E27409E9DD05DEB0F0C83F27E4F63A93B9D4AA715B5398"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ApplicationGroupeEice.Views;
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


namespace ApplicationGroupeEice.Views {
    
    
    /// <summary>
    /// CommunauteView
    /// </summary>
    public partial class CommunauteView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\Views\6_0_CommunauteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel spBoutonsChoix;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\6_0_CommunauteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button boutonEvenements;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Views\6_0_CommunauteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button boutonDefis;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Views\6_0_CommunauteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button boutonClassement;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Views\6_0_CommunauteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dpAffichage;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Views\6_0_CommunauteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button boutonRetour;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Views\6_0_CommunauteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl ActiveItem;
        
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
            System.Uri resourceLocater = new System.Uri("/ApplicationGroupeEice;component/views/6_0_communauteview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\6_0_CommunauteView.xaml"
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
            this.spBoutonsChoix = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.boutonEvenements = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Views\6_0_CommunauteView.xaml"
            this.boutonEvenements.Click += new System.Windows.RoutedEventHandler(this.boutonEvenements_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.boutonDefis = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\Views\6_0_CommunauteView.xaml"
            this.boutonDefis.Click += new System.Windows.RoutedEventHandler(this.boutonDefis_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.boutonClassement = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\Views\6_0_CommunauteView.xaml"
            this.boutonClassement.Click += new System.Windows.RoutedEventHandler(this.boutonClassement_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dpAffichage = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 6:
            this.boutonRetour = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\Views\6_0_CommunauteView.xaml"
            this.boutonRetour.Click += new System.Windows.RoutedEventHandler(this.boutonRetour_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ActiveItem = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
