using ComponentArchi.Model;
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