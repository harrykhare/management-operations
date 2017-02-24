using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.EmpMgmt.BO;
using TCS.EmpMgmt.DAL;
using System.Data;

namespace TCS.EmpMgmt.BLL
{
    public class EmployeeBLL
    {
        public int InsertEmp(EmployeeBO objEmployeeBO)
        {
            try
            {
                DBConnection objDBConnection = new DBConnection();
                return objDBConnection.InsertEmp(objEmployeeBO);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public DataSet GetEmpDetails(int EmpID)
        {
            try
            {
                DBConnection objDBConnection = new DBConnection();
                return objDBConnection.GetEmpDetails(EmpID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ValidateEmpUser(LoginBO objLoginBO)
        {
            try
            {
                DBConnection objDBConnection = new DBConnection();
                return objDBConnection.ValidateEmpUser(objLoginBO);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
