using ComponentArchi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public sealed partial class Result3Control : UserControl, INotifyPropertyChanged
    {
        /*
        public static readonly DependencyProperty PersonInfoProperty = DependencyProperty.Register("PersonInfo", typeof(Person), typeof(Result3Control), new PropertyMetadata(null));
        public Person PersonInfo
        {
            get { return (Person)GetValue(PersonInfoProperty); }
            set { SetValue(PersonInfoProperty, value); }
        }

        public static readonly DependencyProperty PersonInfosProperty = DependencyProperty.Register("PersonInfos", typeof(List<Person>), typeof(Result3Control), new PropertyMetadata(null));
        public List<Person> PersonInfos
        { 
            get { return (List<Person>)GetValue(PersonInfosProperty); }
            set { SetValue(PersonInfosProperty, value); }
        }
        */

        private Person _personInfo;
        public Person PersonInfo
        {
            get { return _personInfo; }
            set { _personInfo = value; RaisePropertyChanged("PersonInfo");}
        }

        private List<Person> _personInfos;
        public List<Person> PersonInfos
        { 
            get { return _personInfos; }
            set { _personInfos = value; RaisePropertyChanged("PersonInfos");}
        }


        public Result3Control()
        {
            this.InitializeComponent();
            DataContext=this;
        }


        //This is the notofier
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }

        }
    }
}
