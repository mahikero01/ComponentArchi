using ComponentArchi.Model;
using ComponentArchi.ViewModel;
using System.Collections.Generic;
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

           

            PassData2();
            
        }

        public void PassData(Person person)  //This will pass data to the component
        { 
            resultControl.UpdateComponent(person);
        }

        public void PassData2()
        { 
            var PersonInfos = CreateMockData();

            var personTemp = new Person();
            personTemp.FirstName = "Rico mji";
            _mainPageVM.PersonInfo2 = personTemp;

          
            personListControl.PersonInfos = PersonInfos;
            personListControl.PersonInfo = personTemp;

        }

        private List<Person> CreateMockData()
        { 
            List<Person> persons = new List<Person>();
            Person person;

            for(int p = 1; p < 11; ++p)
            { 
                person = new Person();
                person.FirstName = "Jake";
                person.LastName = "Beluva";
                persons.Add(person);

                person = new Person();
                person.FirstName = "John";
                person.LastName = "Yun";
                persons.Add(person);

                person = new Person();
                person.FirstName = "James";
                person.LastName = "Penote";
                persons.Add(person);
            }

            return persons;
        }
    }
}