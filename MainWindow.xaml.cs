using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WPFTestProject
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadEnvironmentList();
            // Preload data into the TitanAgentStatusViewer for the first environment.
            UpdateRightPanel("Environment A");
        }

        private void LoadEnvironmentList()
        {
            var environments = new List<string>
            {
                "Environment A",
                "Environment B"
            };
            EnvironmentListView.ItemsSource = environments;
        }

        private void EnvironmentListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EnvironmentListView.SelectedItem is string selectedEnvironment)
            {
                UpdateRightPanel(selectedEnvironment);
            }
        }

        private void UpdateRightPanel(string environmentName)
        {
            var data = new List<TitanAgentStatusViewer.MachineData>();
            if (environmentName == "Environment A")
            {
                data.Add(new TitanAgentStatusViewer.MachineData { Id = "A1", Status = "Healthy" });
            }
            else if (environmentName == "Environment B")
            {
                data.Add(new TitanAgentStatusViewer.MachineData { Id = "B1", Status = "Faulted" });
            }

            TitanAgentStatusViewer.Update(data);
        }
    }
}
