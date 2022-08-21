using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerhabaWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TextBox tb_Selam = new TextBox();
            tb_Selam.Size = new Size(250, 50);
            tb_Selam.Location = new Point(100, 20);
            this.Controls.Add(tb_Selam);
        }
    }
}
