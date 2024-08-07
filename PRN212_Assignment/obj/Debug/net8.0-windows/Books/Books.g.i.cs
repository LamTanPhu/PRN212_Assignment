﻿#pragma checksum "..\..\..\..\Books\Books.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B3C31DFD71526B4502D46CF238ABE9A3D8ED1DC0"
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


namespace PRN212_Assignment.Books {
    
    
    /// <summary>
    /// Books
    /// </summary>
    public partial class Books : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\..\Books\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTextBox;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\..\Books\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchButton;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\..\Books\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid booksDataGrid;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Books\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox bookIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Books\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox titleTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Books\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox authorTextBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Books\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox genreTextBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Books\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox publicationYearTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Books\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox statusComboBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Books\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBookButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Books\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editBookButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Books\Books.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteBookButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PRN212_Assignment;V1.0.0.0;component/books/books.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Books\Books.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.searchTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.searchButton = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\..\..\Books\Books.xaml"
            this.searchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.booksDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 8 "..\..\..\..\Books\Books.xaml"
            this.booksDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BooksDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bookIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.titleTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.authorTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.genreTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.publicationYearTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.statusComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.addBookButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\Books\Books.xaml"
            this.addBookButton.Click += new System.Windows.RoutedEventHandler(this.AddBookButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.editBookButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Books\Books.xaml"
            this.editBookButton.Click += new System.Windows.RoutedEventHandler(this.EditBookButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.deleteBookButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\Books\Books.xaml"
            this.deleteBookButton.Click += new System.Windows.RoutedEventHandler(this.DeleteBookButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

