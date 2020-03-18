using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace AsyncAwait
{
    public partial class Form1 : Form
    {


        ArrayList sortida = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Stopwatch sw = new Stopwatch();
            sw.Start();


            foreach (string d in System.IO.Directory.GetDirectories(@"C:\Users\roshs\Documents\prueba"))
            {
                foreach (string s in System.IO.Directory.GetFiles(d))
                {
                    sortida.Add(s);
                    System.Threading.Thread.Sleep(1);
                }
            }
            toList();

            sw.Stop();
            timer1.Text = sw.Elapsed.TotalSeconds.ToString() + " segundos";
        }

        private void toList()
        {
            ListBox _list = new ListBox();
            for(int i = 0; i < sortida.Count; i++)
            {
                _list.Items.Add(sortida.IsReadOnly);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();



            sw.Stop();
            timer2.Text = sw.Elapsed.ToString("hh\\:mm\\:ss\\.fff" + "segundos");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
