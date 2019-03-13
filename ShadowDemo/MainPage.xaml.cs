using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ShadowDemo {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Employee> Employees { get; } = new List<Employee> {
                new Employee("Fons", 2000),
                new Employee("Jim", 4000),
                new Employee("Ellen", 3000),
                new Employee("Eric", 1000),
                new Employee("Mike", 8000),
                new Employee("Anna", 6000),
                new Employee("Leo", 1000),
                new Employee("Mick", 1000),
            };


        public MainPage() {
            this.InitializeComponent();
            MyThemeShadow.Receivers.Add(BgRectangle);
        }
    }
}

