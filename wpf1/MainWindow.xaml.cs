using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;
using wpf1.GymDataSetTableAdapters;

namespace wpf1
{
    public partial class MainWindow : Window
    {
        private List<Page> pages;
        private int pageIndex = 0;
        public MainWindow()
        {
            InitializeComponent();

           pages = new List<Page>()
           {
                new PageCustomer(),
                new PageTrainer(),
                new PageSeasonticket(),
                new PageCustomerEF(),
                new PageTrainerEF(),
                new PageSeasonticketEF(),
           };


            frame.Content = pages[pageIndex];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = pages[pageIndex];
            pageIndex = pageIndex < pages.Count - 1 ? pageIndex + 1 : 0;
        }
    }
}