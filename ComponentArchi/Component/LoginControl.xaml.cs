using ComponentArchi.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ComponentArchi.Component
{
    public sealed partial class LoginControl : UserControl
    {
        /*
        public static readonly DependencyProperty PersonInfoProperty = DependencyProperty.Register("PersonInfo", typeof(Person), typeof(LoginControl), new PropertyMetadata(null));
        public Person PersonInfo
        {
            get { return (Person)GetValue(PersonInfoProperty); }
            set { SetValue(PersonInfoProperty, value); }
        }
        */

        //this will hold the assigned method
        public static readonly DependencyProperty SubmitCommandProperty = DependencyProperty.Register("SubmitCommand", typeof(ICommand), typeof(LoginControl), new PropertyMetadata(null));
        public ICommand SubmitCommand
        {
            get { return (ICommand)GetValue(SubmitCommandProperty); }
            set { SetValue(SubmitCommandProperty, value); }
        }
        
        public LoginControl()
        {
            this.InitializeComponent();
            DataContext = this;
        }
    }
}