using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapReceivers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Befor run this App (this code) you must run the first app (Sender) to create this variable in memory
            using (var mmf = MemoryMappedFile.OpenExisting("MMport1"))  
            {
                using (var accessor = mmf.CreateViewAccessor(0, 20))
                {

                    double A = accessor.ReadDouble(0);
                    txt_display.Text = Convert.ToString(A);

                }
            }
        }
    }
}
