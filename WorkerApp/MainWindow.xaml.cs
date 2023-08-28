using BLL.Models;
using BLL.Services;
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

namespace WorkerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> workTypes; 

        public MainWindow()
        {
            InitializeComponent();
            //workTypes = new List<WorkType>
            //{
            //    new WorkType(1,"Cleaning"),
            //    new WorkType(2,"RoomService"),
            //    new WorkType(3,"Maintenance"),

            //};
            workTypes = BModelHelper.GetWorkTypes();
            cbTypeOfWork.DataContext = workTypes;
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            var selected = cbTypeOfWork.SelectedItem;
            if(selected != null)
            {
                string wt = selected as string;
                TasksWindow tw = new TasksWindow(wt);
                tw.Loaded += Tw_Loaded;
                tw.ShowDialog();
               
                
               
            } else
            {
                MessageBox.Show("Please Select Type");
            }
            
        }

        private void Tw_Loaded(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}

// DisplayMemberPath="Title" SelectedValuePath="Id"