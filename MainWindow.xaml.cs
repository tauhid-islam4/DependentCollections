using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DependentCollections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Student> allStudents = new List<Student>();
            allStudents.Add(new Student( 1, "John", "Snow", "1234", "Nights Watch"));
            allStudents.Add(new Student( 2, "Brandon", "Stark", "5678", "North"));
            allStudents.Add(new Student( 3, "Cersei", "Lannister", "1357", "Red Keep"));
            allStudents.Add(new Student( 4, "Little", "Finger", "2468", "Everywhere"));

            ComboBoxStudent.ItemsSource = allStudents;
            
        }

        private void ComboBoxStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (ComboBoxStudent.SelectedItem != null) {
                TextBoxStudent.Text = ((Student)(ComboBoxStudent.SelectedItem)).DetailedToString();
            }
            if (ComboBoxStudent.SelectedItem != null) { 
                TextBlockStudent.Text = ((Student)(ComboBoxStudent.SelectedItem)).DetailedToString();
            }
             
        }
    }

    public class Student {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Student()
        {
        }
        public Student(int id, string firstName, string lastName, string phoneNumber, string address) { 
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Address = address;

        }

        override
            public string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

        public string DetailedToString() {
            return this.FirstName + " " + this.LastName + "\n" + this.PhoneNumber + "\n" + this.Address;
        }
    }
}