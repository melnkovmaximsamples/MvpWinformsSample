using MVP_Sample.View;
using MVP_Sample.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Sample
{
    public partial class Form1 : Form, IRectangle
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string lengthText
        {
            get
            {
                return this.tbLength.Text;
            }
            set
            {
                this.tbLength.Text = value;
            }
        }

        public string widthText
        {
            get
            {
                return this.tbWidth.Text;
            }
            set
            {
                this.tbWidth.Text = value;
            }
        }

        public string resultText
        {
            get
            {
                return this.result.Text;
            }
            set
            {
                this.result.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PresenterRectangle presenter = new PresenterRectangle(this);
            presenter.CalculateArea();
        }
    }
}
