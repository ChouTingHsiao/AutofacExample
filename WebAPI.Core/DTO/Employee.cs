using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Core.DTO
{
    public class Employee
    {
        public string ID { get; set; }
        public string BUSINESSRULEID { get; set; }
        public string UnitCode { get; set; }
        public string UNITNAME { get; set; }
        public string PUnitCode { get; set; }
        public string PUNITNAME { get; set; }
        public string EMPLOYEEID { get; set; }
        public string CARDNUM { get; set; }
        public string AS400ID { get; set; }
        public string TRUENAME { get; set; }
        public string GENDER { get; set; }
        public int ACCESSIONSTATE { get; set; }
        public string JOBCODE { get; set; }
        public string JOBNAMES { get; set; }
        public string EMPLOYEETYPEID { get; set; }
        public string EMPLOYEETYPENAME { get; set; }
        public string EMPLOYEECHARID { get; set; }
        public string EMPLOYEECHARNAME { get; set; }
        public string JOBTYPEID { get; set; }
        public string JOBTYPENAME { get; set; }
        public string ATTENDONDATE { get; set; }
        public string DIMISSIONDATE { get; set; }
        public string NOPAYSTATUS { get; set; }
        public string COMPANYEMAIL { get; set; }
        public string MobilePhone { get; set; }
        public string Integrated_Account { get; set; }
        public string CREATEDBY { get; set; }
        public System.DateTime CREATIONTIME { get; set; }
    }
}
