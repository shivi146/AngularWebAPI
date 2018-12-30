using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VisaTracking.Models
{
    public class VisaDetails
    {
       // public int VisaId { get; set; }
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public string VisaStageCode { get; set; }
        public DateTime VisaDate { get; set; }
        public string VisaStatus { get; set; }
    }
}