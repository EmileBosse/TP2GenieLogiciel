﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPharmacie
{
    public partial class WIZZ04 : Form
    {
        public WIZZ04()
        {
            InitializeComponent();
        }

        private void btnSuivantMedicament_Click(object sender, EventArgs e)
        {
            WIZZ05 c = new WIZZ05();
            c.Show();
            this.Close();
        }

        private void btnPrecedentMedicament_Click(object sender, EventArgs e)
        {
            Parent.Show();
            this.Close();
        }

        private void btnCancelMedicament_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
