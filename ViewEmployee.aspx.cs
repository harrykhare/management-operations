using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using TCS.EmpMgmt.BLL;
using System.Data;

namespace TCS.EmpMgmtLayering.UI
{
    public partial class ViewEmployee : System.Web.UI.Page
    {
        
        EmployeeBLL objEmployeeBLL = new EmployeeBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Convert.ToString(Session["UserID"])))
            {
                if (!IsPostBack)
                {

                    BindGrid();
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
           
        }
        void BindGrid()
        {
            DataSet ds = new DataSet();
            ds = objEmployeeBLL.GetEmpDetails(0);

            gvEmpDetails.DataSource = ds;
            gvEmpDetails.DataBind();
        }

        protected void gvEmpDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmdEdit")
            {
                Session["EmployeeMgmt_EmpID"] = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("AddEmployee.aspx");
            }
            else
            { 
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddEmployee.aspx");
        }

        
    }
}
