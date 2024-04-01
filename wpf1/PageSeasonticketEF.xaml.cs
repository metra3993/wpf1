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

namespace wpf1
{
    /// <summary>
    /// Логика взаимодействия для PageSeasonticketEF.xaml
    /// </summary>
    public partial class PageSeasonticketEF : Page
    {
        private GymEntities ticket = new GymEntities();
        public PageSeasonticketEF()
        {
            InitializeComponent();
            SeasonticketEFDataGrid.ItemsSource = ticket.seasonticket.ToList();
        }
    }
}
