using System;
using System.Windows.Forms;

namespace Tempo
{
    public partial class CitiesList : Form
    {
        private static Form1 _form1;
        public CitiesList(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void CitiesList_Load(object sender, EventArgs e)
        {
            var regions = Methods.GetRegion();

            foreach (var r in regions.Data)
            {
                listBox1.Items.Add(r.Local);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.City = listBox1.SelectedItem.ToString();
            _form1.Form1_Load(sender, e);
            Close();
        }
    }
}