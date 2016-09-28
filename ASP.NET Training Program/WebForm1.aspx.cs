using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Training_Program
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        /*   Hidden Field in ASP.NET - Part 34
         * 
         * 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadEmployee();
            }
        }

        private void LoadEmployee()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sqlQuery = "Select Id, Name, Gender, DeptName from tblEmployees where Id=202";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        txtName.Text = rdr["Name"].ToString();
                        txtGender.Text = rdr["Gender"].ToString();
                        txtDept.Text = rdr["DeptName"].ToString();
                        HiddenField1.Value = rdr["Id"].ToString();
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                string sqlQuery = "Update tblEmployees set Name=@Name, Gender=@Gender, DeptName=@DeptName where Id=@Id";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@DeptName", txtDept.Text);
                cmd.Parameters.AddWithValue("@ID", HiddenField1.Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                txtName.Text = "";
                txtGender.Text = "";
                txtDept.Text = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            LoadEmployee();
        }*/


    }
}