﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
    /// Логика взаимодействия для PageTrainerEF.xaml
    /// </summary>
    public partial class PageTrainerEF : Page
    {
        private GymEntities trainer = new GymEntities();
        public PageTrainerEF()
        {
            InitializeComponent();
            TrainerEFDataGrid.ItemsSource = trainer.trainer.ToList();
        }
    }
}
