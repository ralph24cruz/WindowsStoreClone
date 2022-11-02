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

namespace WindowsStoreClone.UserControls.HamburgerMenuViews
{
    /// <summary>
    /// Interaction logic for hamburgerMenuApplist.xaml
    /// </summary>
    public partial class hamburgerMenuApplist : UserControl
    {
        
        public List<HamburgerMenuApp> AllApps;
        public List<HamburgerMenuApp> AppsOnFilter;
        public hamburgerMenuApplist()
        {
            
            AllApps = new List<HamburgerMenuApp>();
            AppsOnFilter = new List<HamburgerMenuApp>();
            InitializeComponent();
           
            for (int i = 0; i < 15; i++)
            {
                AddNewHamApp();
            }
        }
        
        private void AddNewHamApp()
        {
            HamburgerMenuApp anApp = new HamburgerMenuApp();
            MainStackPanel.Children.Add(anApp);
            AllApps.Add(anApp);
        }
       
        public void FilterByType(string inFilter)
        {
            AppsOnFilter = AllApps.Where(p => p.Type == inFilter).ToList<HamburgerMenuApp>();
            MainStackPanel.Children.Clear();
            foreach (HamburgerMenuApp item in AppsOnFilter)
            {
                MainStackPanel.Children.Add(item);
            }
        }
        
        public void AddAll()
        {
            MainStackPanel.Children.Clear();
            foreach (HamburgerMenuApp item in AllApps)
            {
                MainStackPanel.Children.Add(item);
            }
        }
        
        public void SortByName()
        {
            List<HamburgerMenuApp> AllAppsSorted = AllApps.OrderBy(p => p.AppName).ToList<HamburgerMenuApp>();
            MainStackPanel.Children.Clear();
            foreach (HamburgerMenuApp item in AllAppsSorted)
            {
                MainStackPanel.Children.Add(item);
            }
        }
        
        public void SortByDate()
        {
            List<HamburgerMenuApp> AllAppsSorted = AllApps.OrderByDescending(p => p.Purchased).ToList<HamburgerMenuApp>();
            MainStackPanel.Children.Clear();
            foreach (HamburgerMenuApp item in AllAppsSorted)
            {
                MainStackPanel.Children.Add(item);
            }
        }


    }
}
