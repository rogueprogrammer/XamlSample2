using System.Collections.Generic;
using System.Windows.Controls;

namespace WPFTestProject
{
    public partial class TitanAgentStatusViewer : UserControl
    {
        public TitanAgentStatusViewer()
        {
            InitializeComponent();
        }

        public void Update(List<MachineData> statuses)
        {
            DetailsDataGrid.ItemsSource = statuses;
        }

        public class MachineData
        {
            public string Id { get; set; }
            public string Status { get; set; }
        }
    }
}
