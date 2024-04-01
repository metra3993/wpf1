﻿using System;
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
    /// Логика взаимодействия для PageCustomer.xaml
    /// </summary>
    public partial class PageCustomer : Page
    {
        customerTableAdapter customer = new customerTableAdapter();
        public PageCustomer()
        {
            InitializeComponent();
            CustomerDataGrid.ItemsSource = customer.GetData();
        }
    }
}
