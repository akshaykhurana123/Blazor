using System;
using DevExpress.XtraReports.UI;
using BlazorDemo.Reports;

namespace BlazorDemo.Reports.InteractiveSorting {
    public partial class Report {
        public Report() {
            InitializeComponent();
            Name = ReportNames.InteractiveSortingName;
            DisplayName = ReportNames.InteractiveSorting;
        }
    }
}
