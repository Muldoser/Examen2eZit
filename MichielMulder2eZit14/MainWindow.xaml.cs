using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using Newtonsoft.Json;

namespace MichielMulder2eZit14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Personen> allProfiles { get; set; }
        public ObservableCollection<Friend> AllFriends { get; set; }
        private Rootobject data;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                ProfileListing.DataContext = this;
                StreamReader r = new StreamReader("so4data.json");
                string jsondata = r.ReadToEnd();
                Rootobject data = JsonConvert.DeserializeObject<Rootobject>(jsondata);

                allProfiles = new ObservableCollection<Personen>();
                foreach (var p in data.Personen)
                {
                    allProfiles.Add(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProfileListing_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                //MessageBox.Show(Convert.ToString(ProfileListing.SelectedIndex));
                

                InfoListing.DataContext = this;

                /*ProfileListing.DataContext = this;
                StreamReader r = new StreamReader("so4data.json");
                string jsondata = r.ReadToEnd();
                Rootobject data = JsonConvert.DeserializeObject<Rootobject>(jsondata);

                allProfiles = new ObservableCollection<Personen>();

                foreach (var p in data.Personen)
                {
                    allProfiles.Add(p);
                }*/

                /*foreach (var p in data.Personen)
                {
                    if (ProfileListing.SelectedIndex != -1)
                    {
                        if (ProfileListing.SelectedIndex == p.index)
                        {
                            MessageBox.Show(Convert.ToString(allProfiles[ProfileListing.SelectedIndex]));
                            InfoListing.DataContext = p;

                        }

                    }
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
