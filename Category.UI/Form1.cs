using Category.UI.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Category.UI
{
    public partial class FormCategory : Form
    {
        public event EventHandler ShowBtn;
        public event EventHandler DelBtn;
        public event EventHandler AddBtn;
        public event EventHandler UpdBtn;


        public BindingSource bsForm = new BindingSource();
        public BindingSource bsDGW = new BindingSource();
        

        public FormCategory()
        {
            InitializeComponent();
            new _Presenter(this);
            dGW1.DataSource = bsDGW;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBtn(sender, e);
        }
        private void Show_btn_Click(object sender, EventArgs e)
        {
            
            ShowBtn(sender, e);
            
        }

        private void dGW1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            tbCatId.Text = dGW1.CurrentRow.Cells[0].Value.ToString();
            tbCatName.Text = dGW1.CurrentRow.Cells[1].Value.ToString();
        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
            DelBtn(sender, e);
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            UpdBtn(sender, e);
        }
    }
}
