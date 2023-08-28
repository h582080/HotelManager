using BLL.Services;
using BLL.Models;
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
using System.Windows.Shapes;
using BLL.Services.Contracts;

namespace WorkerApp
{
    /// <summary>
    /// Interaction logic for TasksWindow.xaml
    /// </summary>
    public partial class TasksWindow : Window
    {
        IServiceRequestService _requestService;
        List<ServiceRequest> _tasks;
        List<ServiceRequest> _myTasks;
        string _workType;
        public  TasksWindow(string wt)
        {
            InitializeComponent();
            _requestService = new ServiceRequestService();
            _tasks = new List<ServiceRequest>();
            _myTasks = new List<ServiceRequest>();
          //  lvMyTasks.ItemsSource = _myTasks;
            _workType = wt;
            populateTasksData();
            lblType.Content = wt;
           
           
        }

        async void populateTasksData()
        {
            // label1.Text = "Loading data";
            _tasks = await _requestService.GetServiceRequestsByType(_workType);
            lvTasks.ItemsSource = _tasks.Where(sr => sr.Status == "New");
            //  label1.Text = "Loading done";

        }

        async Task populateMyTasksData()
        {
            _myTasks = await _requestService.GetServiceRequestsByType(_workType);
            lvMyTasks.ItemsSource = _myTasks.Where(sr => sr.Status == "InProgress");

        }

        private  void btnReload_Click(object sender, RoutedEventArgs e)
        {
            populateTasksData();
        }

        private async void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var request =   lvTasks.SelectedItem as ServiceRequest;
            if(request != null)
            {
                try
                {
                    request.Status = "InProgress";
                    _requestService.UpdateServiceRequest(request);
                    populateTasksData();
                 //  await populateMyTasksData();
                    lvMyTasks.Items.Add(request);
                  // lvMyTasks.ItemsSource = _myTasks;
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
              
            }
            else
            {
                MessageBox.Show("Please Select a Request");

            } 
                
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var request = lvMyTasks.SelectedItem as ServiceRequest;
            if (request != null)
            {
                try
                {
                    request.Status = "Complete";
                    _requestService.UpdateServiceRequest(request);
                    lvMyTasks.Items.Remove(request);
                   // await populateMyTasksData();
                    // lvMyTasks.ItemsSource = _myTasks;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please Select a Request");

            }
        }

        private void btnAddNote_Click(object sender, RoutedEventArgs e)
        {
            var request = lvMyTasks.SelectedItem as ServiceRequest;
            if (request != null)
            {
                NotesWindow inputDialog = new NotesWindow();
                if (inputDialog.ShowDialog() == true)
                {
                   request.Notes = inputDialog.Notes;
                    _requestService.UpdateServiceRequest(request);
                    lvMyTasks.Items.Refresh();

                }
                  

            }
            else
            {
                MessageBox.Show("Please Select a Request");

            }
        }
    }
}
