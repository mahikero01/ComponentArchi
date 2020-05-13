using ComponentArchi.Model;
using ComponentArchi.ViewModel;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ComponentArchi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainPageVM _mainPageVM;  //ViewModel

        public MainPage()
        {
            this.InitializeComponent();
            _mainPageVM = new MainPageVM(this);
            DataContext = _mainPageVM;
        }

        public void PassData(Person person)  //This will pass data to the component
        { 
            resultControl.UpdateComponent(person);
        }
    }
}