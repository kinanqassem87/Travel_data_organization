using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Travel_data_organization.PL
{
    public partial class FRM_Pic1Zoom : Form
    {
        public FRM_Pic1Zoom(Image pic1)
        {
            InitializeComponent();
            pictureBox1.Image = pic1;
        }
    }
}
