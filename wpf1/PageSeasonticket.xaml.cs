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
using wpf1.GymDataSetTableAdapters;

namespace wpf1
{
    /// <summary>
    /// Логика взаимодействия для PageSeasonticket.xaml
    /// </summary>
    public partial class PageSeasonticket : Page
    {
        seasonticketTableAdapter ticket = new seasonticketTableAdapter();
        public PageSeasonticket()
        {
            InitializeComponent();
            SeasonticketDataGrid.ItemsSource = ticket.GetData();
        }
    }
}
