﻿#pragma checksum "..\..\..\..\Pages\BorrowBooks\UCBorrowBooks.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4B87A4CC7ACE82F81E8A6D209C16852C93A9E9E6"
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


namespace WPF_LibraryManagement {
    
    
    /// <summary>
    /// BorrowBooks
    /// </summary>
    public partial class BorrowBooks : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 106 "..\..\..\..\Pages\BorrowBooks\UCBorrowBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdReader;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\Pages\BorrowBooks\UCBorrowBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtStatus;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\Pages\BorrowBooks\UCBorrowBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IdReaderSearch;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\Pages\BorrowBooks\UCBorrowBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgListCallCard;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\..\Pages\BorrowBooks\UCBorrowBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBookSearch;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\..\Pages\BorrowBooks\UCBorrowBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\..\..\Pages\BorrowBooks\UCBorrowBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lsbCurrentBook;
        
        #line default
        #line hidden
        
        
        #line 209 "..\..\..\..\Pages\BorrowBooks\UCBorrowBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lsbBorrowBook;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_LibraryManagement;component/pages/borrowbooks/ucborrowbooks.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\BorrowBooks\UCBorrowBooks.xaml"
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
            case 3:
            this.txtIdReader = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtStatus = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.IdReaderSearch = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\..\..\Pages\BorrowBooks\UCBorrowBooks.xaml"
            this.IdReaderSearch.Click += new System.Windows.RoutedEventHandler(this.IdReaderSearch_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dtgListCallCard = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.txtBookSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 171 "..\..\..\..\Pages\BorrowBooks\UCBorrowBooks.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BookSearch_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 173 "..\..\..\..\Pages\BorrowBooks\UCBorrowBooks.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.lsbCurrentBook = ((System.Windows.Controls.ListBox)(target));
            return;
            case 11:
            this.lsbBorrowBook = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 34 "..\..\..\..\Pages\BorrowBooks\UCBorrowBooks.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CurrentCard_Click);
            
            #line default
            #line hidden
            break;
            case 2:
            
            #line 57 "..\..\..\..\Pages\BorrowBooks\UCBorrowBooks.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BorrowCard_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
