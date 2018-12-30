using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VisaTracking.DBContext;
using VisaTracking.Models;

namespace VisaTracking.Controllers
{
    public class VisaController : ApiController
    {
        ApplContext dbContext = new ApplContext();
        [HttpPost]
        public HttpResponseMessage InsertVisaDetails(VisaDetails visaDetails)
        {
            try
            {
               // dbContext.VisaDetails.Add(visaDetails);
                //dbContext.SaveChanges();
                var message = Request.CreateResponse(HttpStatusCode.Created, visaDetails);
                return message;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        public IEnumerable<VisaDetails> GetVisaDetails()
        {
            VisaDetails visaDetail = new VisaDetails();
            visaDetail.EmpId = "12345";
            visaDetail.EmpName = "Shivangi";
            visaDetail.VisaStageCode = "SaQa";
            visaDetail.VisaDate = DateTime.Now;
            visaDetail.VisaStatus = "Applied";

            List<VisaDetails> lst = new List<VisaDetails>();
            lst.Add(visaDetail);
            return lst;

            //return dbContext.VisaDetails.ToList();
        }



        [HttpGet]
        public IEnumerable<VisaDetails> GetEmpVisaDetails(string name)
        {
            VisaDetails visaDetail = new VisaDetails();
            visaDetail.EmpId = "12345";
            visaDetail.EmpName = "Rishab";
            visaDetail.VisaStageCode = "SaQa";
            visaDetail.VisaDate = DateTime.Now;
            visaDetail.VisaStatus = "Applied";
            VisaDetails visaDetail1 = new VisaDetails();
            visaDetail1.EmpId = "12345";
            visaDetail1.EmpName = "BangaliBabu";
            visaDetail1.VisaStageCode = "SaQa";
            visaDetail1.VisaDate = DateTime.Now;
            visaDetail1.VisaStatus = "Applied";
            List<VisaDetails> lst = new List<VisaDetails>();
            lst.Add(visaDetail);
            lst.Add(visaDetail1);
            return lst;
            //return dbContext.VisaDetails.ToList();
        }

        [HttpGet]
        public IEnumerable<VisaDetails> GetEmpVisaDetailsById(string id)
        {
            VisaDetails visaDetail = new VisaDetails();
            visaDetail.EmpId = "12345";
            visaDetail.EmpName = "Rishab";
            visaDetail.VisaStageCode = "SaQa";
            visaDetail.VisaDate = DateTime.Now;
            visaDetail.VisaStatus = "Applied";           
            List<VisaDetails> lst = new List<VisaDetails>();
            lst.Add(visaDetail);           
            return lst;
            //return dbContext.VisaDetails.ToList();
        }
    }
}
