using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;

namespace TheMachineClient
{
    public partial class MainWindow : DevExpress.XtraEditors.XtraForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tabbedView_QueryControl(object sender, QueryControlEventArgs e)
        {
            Panel child = new Panel();
            LabelControl label = new LabelControl();

            label.Dock = DockStyle.Fill;
            label.Text = "Test Test Test";
            child.Controls.Add(label);
            
            e.Control = child;
        }

        private void testViewBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            documentManager.View.AddDocument("Test View", "TestControlName");
        }
    }
}