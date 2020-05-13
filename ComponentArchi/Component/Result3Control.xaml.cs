using ComponentArchi.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class Result3Control : UserControl
    {
        public static readonly DependencyProperty PersonInfoProperty = DependencyProperty.Register("PersonInfo", typeof(Person), typeof(Result3Control), new PropertyMetadata(null));
        public Person PersonInfo
        {
            get { return (Person)GetValue(PersonInfoProperty); }
            set { SetValue(PersonInfoProperty, value); }
        }

        public Result3Control()
        {
            this.InitializeComponent();
            DataContext=this;
        }
    }
}
