﻿using InternshipsAdmin.AppLogic.Contracts;
using InternshipsAdmin.Domain;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace InternshipsAdmin.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(ICompanyRepository companyRepository, IStudentsRepository studentsRepository)
        {
            InitializeComponent();
            throw new NotImplementedException();
        }


        private void UpdateComboboxes()
        {
            throw new NotImplementedException();
        }

        private void CompanyDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }


        private void AddStudentForCompanyButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RemoveStudentFromSupervisorButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

    }

}


