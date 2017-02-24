using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCS.EmpMgmt.BO;
using TCS.EmpMgmt.BLL;
using System.Data;

namespace TCS.EmpMgmtLayering.UI
{
    public partial class Login : System.Web.UI.Page
    {
        LoginBO objLoginBO = new LoginBO();
        EmployeeBLL objEmployeeBLL = new EmployeeBLL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            objLoginBO.UserName = Convert.ToString(txtUserName.Text);
            objLoginBO.Password = Convert.ToString(txtPassword.Text);
            DataSet ds = new DataSet();
            ds = objEmployeeBLL.ValidateEmpUser(objLoginBO);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Session["UserID"] = ds.Tables[0].Rows[0]["UserID"];
                    Response.Redirect("ViewEmployee.aspx");
                }
                else
                {
                    Session["UserID"] = null;
                    this.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('User doenot exist for the given credentials');</script>");
                }
            }
            else
            {
                Session["UserID"] = null;
            }
        }
    }
}