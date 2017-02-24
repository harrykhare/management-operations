using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.EmpMgmt.BO
{
    public class EmployeeBO
    {
        private int _EmployeeID;

        public int EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }
        private string _EmployeeName;

        public string EmployeeName
        {
            get { return _EmployeeName; }
            set { _EmployeeName = value; }
        }

        private double _BasicSalary;

        public double BasicSalary
        {
            get { return _BasicSalary; }
            set { _BasicSalary = value; }
        }

        private double _VariableAllowance;

        public double VariableAllowance
        {
            get { return _VariableAllowance; }
            set { _VariableAllowance = value; }
        }
        
        
    }
}
