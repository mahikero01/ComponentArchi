using ComponentArchi.Model;
using System.Collections.Generic;
using System.Windows.Input;
using Vivonet.WindowApp.Utility;

namespace ComponentArchi.ViewModel
{
    class MainPageVM //: INotifyPropertyChanged
    {
        public ICommand SubmitInfoCommand => new ParametrizedRelayCommand(SubmitInfo);  //this will pass method to the component

        private MainPage _mainPage; //Holds the Main Component

        private Person _personInfo;   //common repo 
        public Person PersonInfo
        {
            get { return _personInfo; }
            set { _personInfo = value; }
        }

        private Person _personInfo2;   //common repo 
        public Person PersonInfo2
        {
            get { return _personInfo2; }
            set { _personInfo2 = value; }
        }

        private List<Person> _personInfos;   //common repo 
        public List<Person> PersonInfos
        {
            get { return _personInfos; }
            set { _personInfos = value; }
        }

        public MainPageVM(MainPage mainPage)
        { 
            PersonInfo = new Person();
            _mainPage = mainPage;
        }
        
        private void SubmitInfo(object param)
        {
            PersonInfo.FirstName = param.ToString();

            _mainPage.PassData(PersonInfo);
        }

        /*
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected internal virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        */
    }
}