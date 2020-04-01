using Category.DAL;
using Category.DAL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Category.UI.Presenter
{
    class _Presenter
    {
        public FormCategory Form;        
        public _Presenter(FormCategory F)
        {
            Form = F;
            string connectionString = ConfigurationManager.ConnectionStrings["Shop"].ConnectionString;
            Form.ShowBtn += FormShowBtn;
            Form.DelBtn += FormDel;
            Form.AddBtn += FormAddBtn;
            Form.UpdBtn += FormUpdBtn;

        }
        private void GetData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Shop"].ConnectionString;
            CategoryStorage cs = new CategoryStorage();
            cs.Connection = new System.Data.SqlClient.SqlConnection(connectionString);
            var table = cs.GetData();
            //Form.bsForm.DataSource = collection;
            Form.bsDGW.DataSource = table;
        }
        private void FormShowBtn(object sender, EventArgs e)
        {
            GetData();            
        }
        private void FormDel(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Shop"].ConnectionString;
            CategoryStorage cs = new CategoryStorage();
            cs.Connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string tmp = Form.dGW1.CurrentRow.Cells[0].Value.ToString();
            int i = Convert.ToInt32(tmp);
            cs.Del(i);
            GetData();
            Form.dGW1.Refresh();
        }
        private void FormAddBtn(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Shop"].ConnectionString;
            CategoryStorage cs = new CategoryStorage();
            cs.Connection = new System.Data.SqlClient.SqlConnection(connectionString);
            var c = cs.Add(new _Category { CategoryName = Form.tbCatName.Text });
            GetData();
            Form.dGW1.Refresh();
        }
        private void DGW_click(object sender, EventArgs e)
        { }
        private void FormUpdBtn(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Shop"].ConnectionString;
            CategoryStorage cs = new CategoryStorage();
            cs.Connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string tmp = Form.dGW1.CurrentRow.Cells[0].Value.ToString();
            cs.Update(Convert.ToInt32(tmp), Form.tbCatName.Text);
            GetData();
            Form.dGW1.Refresh();
        }        
    }
}
