using ComponentArchi.Model;
using System;
using System.ComponentModel;
using Windows.UI.Xaml.Controls;


// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ComponentArchi.Component
{
    public sealed partial class Result1Control : UserControl, INotifyPropertyChanged
    {
        private Person _personInfo;
        public Person PersonInfo
        { 
            get { return  _personInfo;}
            set { _personInfo = value; RaisePropertyChanged("PersonInfo");}
        }

        public Result1Control()
        {
            this.InitializeComponent();
            DataContext = this;
        }

        //this will update the component
        public void UpdateComponent(object param)
        { 
            PersonInfo = (Person)param;
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

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            
            TimeSpan tes =  timePickme.Time;

            CurrentTime = tes.ToString();

            var test = "Rico";
        }

        private void Button_Click2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            //TimeSpan temp = new TimeSpan(16,15,00);

            //timePickme.Time = temp;

           var test2  = TimeSpan.Parse(CurrentTime);

            timePickme.Time = test2;
          var test = "Rico";
        }

        private string _currentTime;
        public string CurrentTime
        { 
            get { return  _currentTime; }
            set { _currentTime = value;  }
        }

    }
}