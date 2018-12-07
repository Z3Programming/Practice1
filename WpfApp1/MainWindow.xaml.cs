using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //declare carrier name array
        public string[] carrierNames { get; set; }
        
        //set BA Tags
        public Dictionary<string,string> baTags =  new Dictionary<string, string>();

        public MainWindow()
        {
            InitializeComponent();

            //build carrier names array
            carrierNames = new string[] { "","Avatar Book Roll","Avatar Rewrite Book Roll","Geovera Book Roll","Safeco Book Roll","Tower Hill Book Roll" };

            DataContext = this;

            //build carrier name dictionary
            baTags.Add("Avatar Book Roll","abc");
            baTags.Add("Avatar Rewrite Book Roll", "def");
            baTags.Add("Geovera Book Roll", "ghi");
            baTags.Add("Safeco Book Roll", "jkl");
            baTags.Add("Tower Hill Book Roll", "mno");


        }


    }
}
