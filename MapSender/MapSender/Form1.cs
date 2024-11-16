using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CreateMapFileOnRam();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        MemoryMappedFile mmf;
        private bool CreateMapFileOnRam()
        {
            bool shart = false;
            try
            {
                // CreateNew Table on memory
                mmf = MemoryMappedFile.CreateNew("MMport1", 20);
                if (mmf != null) shart = true;
            }
            catch (Exception ex)
            {
                shart = false;
            }
            return shart;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = 0;
            if (double.TryParse(txt_display.Text.Trim(), out a))
            {
                SendToRam(a);
            }
            else
            {
                MessageBox.Show("Enter Number ,Please");
            }
        }

        private bool SendToRam(double Number)
        {
            bool shart = false;
            try
            {
                // push number to Memory
                MemoryMappedViewAccessor accessor = mmf.CreateViewAccessor();
                accessor.Write(0, Number);
                accessor.Dispose();

                shart = true;
            }
            catch (Exception ex)
            {
                shart = false;
            }
            return shart;
        }
    }
}
