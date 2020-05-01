using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteMe
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        public Details(string nom , string prenom , int age) : this()
        {
            this.label_nom.Text = nom;
            this.label_prenom.Text = prenom;
            this.label_age.Text = age.ToString();
        }
    }
}
