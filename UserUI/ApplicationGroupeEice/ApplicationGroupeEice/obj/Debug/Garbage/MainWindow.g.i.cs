﻿#pragma checksum "..\..\..\Garbage\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "030A6C98BA9CEE5849C49FF21184BE7F6607B2B2E912DEB661D1CE55BDAF443E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ApplicationGroupeEice;
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


namespace ApplicationGroupeEice {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\Garbage\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MI_Accueil;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Garbage\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MI_Profil;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Garbage\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MI_MesJeux;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Garbage\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MI_Defis;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Garbage\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MI_Actualités;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Garbage\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MI_Deconnexion;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Garbage\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MI_Amis;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Garbage\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MI_Fermeture;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Garbage\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Contenu;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Garbage\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Hoydihoy;
        
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
            System.Uri resourceLocater = new System.Uri("/ApplicationGroupeEice;component/garbage/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Garbage\MainWindow.xaml"
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
            
            #line 9 "..\..\..\Garbage\MainWindow.xaml"
            ((ApplicationGroupeEice.MainWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 29 "..\..\..\Garbage\MainWindow.xaml"
            ((System.Windows.Controls.Menu)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Menu_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MI_Accueil = ((System.Windows.Controls.MenuItem)(target));
            
            #line 51 "..\..\..\Garbage\MainWindow.xaml"
            this.MI_Accueil.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CliqueSurUnBouton);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\Garbage\MainWindow.xaml"
            this.MI_Accueil.Click += new System.Windows.RoutedEventHandler(this.MI_Accueil_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MI_Profil = ((System.Windows.Controls.MenuItem)(target));
            
            #line 53 "..\..\..\Garbage\MainWindow.xaml"
            this.MI_Profil.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CliqueSurUnBouton);
            
            #line default
            #line hidden
            
            #line 53 "..\..\..\Garbage\MainWindow.xaml"
            this.MI_Profil.Click += new System.Windows.RoutedEventHandler(this.MI_Profil_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MI_MesJeux = ((System.Windows.Controls.MenuItem)(target));
            
            #line 55 "..\..\..\Garbage\MainWindow.xaml"
            this.MI_MesJeux.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CliqueSurUnBouton);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\Garbage\MainWindow.xaml"
            this.MI_MesJeux.Click += new System.Windows.RoutedEventHandler(this.MI_MesJeux_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MI_Defis = ((System.Windows.Controls.MenuItem)(target));
            
            #line 57 "..\..\..\Garbage\MainWindow.xaml"
            this.MI_Defis.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CliqueSurUnBouton);
            
            #line default
            #line hidden
            
            #line 57 "..\..\..\Garbage\MainWindow.xaml"
            this.MI_Defis.Click += new System.Windows.RoutedEventHandler(this.MI_Defis_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MI_Actualités = ((System.Windows.Controls.MenuItem)(target));
            
            #line 59 "..\..\..\Garbage\MainWindow.xaml"
            this.MI_Actualités.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CliqueSurUnBouton);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MI_Deconnexion = ((System.Windows.Controls.MenuItem)(target));
            
            #line 61 "..\..\..\Garbage\MainWindow.xaml"
            this.MI_Deconnexion.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CliqueSurUnBouton);
            
            #line default
            #line hidden
            
            #line 61 "..\..\..\Garbage\MainWindow.xaml"
            this.MI_Deconnexion.Click += new System.Windows.RoutedEventHandler(this.MI_Deconnexion_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MI_Amis = ((System.Windows.Controls.MenuItem)(target));
            
            #line 63 "..\..\..\Garbage\MainWindow.xaml"
            this.MI_Amis.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CliqueSurUnBouton);
            
            #line default
            #line hidden
            
            #line 63 "..\..\..\Garbage\MainWindow.xaml"
            this.MI_Amis.Click += new System.Windows.RoutedEventHandler(this.MI_Amis_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.MI_Fermeture = ((System.Windows.Controls.MenuItem)(target));
            
            #line 69 "..\..\..\Garbage\MainWindow.xaml"
            this.MI_Fermeture.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CliqueSurUnBouton);
            
            #line default
            #line hidden
            
            #line 69 "..\..\..\Garbage\MainWindow.xaml"
            this.MI_Fermeture.Click += new System.Windows.RoutedEventHandler(this.MI_Fermeture_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Contenu = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 12:
            this.Hoydihoy = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
