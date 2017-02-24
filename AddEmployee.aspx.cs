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
    public partial class AddEmployee : System.Web.UI.Page
    {

        EmployeeBO objEmployeeBO = new EmployeeBO();
        EmployeeBLL objEmployeeBLL = new EmployeeBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Convert.ToString(Session["UserID"])))
            {
                if (Session["EmployeeMgmt_EmpID"] != null)
                {
                    ViewState["EmployeeMgmt_EmpID"] = Session["EmployeeMgmt_EmpID"];
                    Session.Remove("EmployeeMgmt_EmpID");
                    BindEmpDetails();
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (ViewState["EmployeeMgmt_EmpID"] != null)
            {
                objEmployeeBO.EmployeeID = Convert.ToInt32(ViewState["EmployeeMgmt_EmpID"]);
            }
            objEmployeeBO.EmployeeName = txtName.Text;
            objEmployeeBO.BasicSalary = Convert.ToDouble(txtBasicSalary.Text);
            objEmployeeBO.VariableAllowance = Convert.ToDouble(txtVariableAllowance.Text);

            int EmpID=objEmployeeBLL.InsertEmp(objEmployeeBO);

            //DataSet ds = new DataSet();
            //ds = objEmployeeBLL.GetEmpDetails(EmpID);
            
        }


        void BindEmpDetails()
        {
            int EmployeeID = Convert.ToInt32(ViewState["EmployeeMgmt_EmpID"]);
            DataSet ds = new DataSet();
            ds = objEmployeeBLL.GetEmpDetails(EmployeeID);
            txtName.Text = Convert.ToString(ds.Tables[0].Rows[0]["EmployeeName"]);
            txtBasicSalary.Text = Convert.ToString(ds.Tables[0].Rows[0]["BasicSalary"]);
            txtVariableAllowance.Text = Convert.ToString(ds.Tables[0].Rows[0]["VariableAllowance"]);

        }

        protected void btnBackToList_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewEmployee.aspx");
        }
    }
}