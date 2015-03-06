using System;
using System.Windows.Forms;



namespace ADO.NET_data_access_template
{


    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'worldDataSet.country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.worldDataSet.country);

        }


    }


}
