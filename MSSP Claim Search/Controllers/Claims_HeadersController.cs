using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MSSP_Claim_Search.Models;

namespace MSSP_Claim_Search.Controllers
{
    public class Claims_HeadersController : Controller
    {
        private ACDW_CLMS_SHCN_MSSPEntities1 db = new ACDW_CLMS_SHCN_MSSPEntities1();

        // GET: Claims_Headers
        public ActionResult Index()
        {
            return View(db.Claims_Headers.ToList());
        }

        // GET: Claims_Headers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Claims_Headers claims_Headers = db.Claims_Headers.Find(id);
            if (claims_Headers == null)
            {
                return HttpNotFound();
            }
            return View(claims_Headers);
        }

        public ActionResult SearchClaimHeader(string ClientMemberKey ,string SeqClaimID)
        {
            if (ClientMemberKey == null)
                ClientMemberKey = "0";
            if (SeqClaimID == null)
                SeqClaimID = "0";
            // (db.sp_Get_ClaimHeader(ClientMemberKey, SeqClaimID);
            ClientMemberKey = "1J21AK7FJ18";
            SeqClaimID = "";

            return View((db.sp_Get_ClaimHeader(ClientMemberKey, SeqClaimID)));
        }

        // GET: Claims_Headers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Claims_Headers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SEQ_CLAIM_ID,SUBSCRIBER_ID,CLAIM_NUMBER,CATEGORY_OF_SVC,PAT_CONTROL_NO,ICD_PRIM_DIAG,PRIMARY_SVC_DATE,SVC_TO_DATE,CLAIM_THRU_DATE,POST_DATE,CHECK_DATE,CHECK_NUMBER,DATE_RECEIVED,ADJUD_DATE,CMS_CertificationNumber,SVC_PROV_ID,SVC_PROV_FULL_NAME,SVC_PROV_NPI,PROV_SPEC,PROV_TYPE,PROVIDER_PAR_STAT,ATT_PROV_ID,ATT_PROV_FULL_NAME,ATT_PROV_NPI,REF_PROV_ID,REF_PROV_FULL_NAME,VENDOR_ID,VEND_FULL_NAME,IRS_TAX_ID,DRG_CODE,BILL_TYPE,ADMISSION_DATE,AUTH_NUMBER,ADMIT_SOURCE_CODE,ADMIT_HOUR,DISCHARGE_HOUR,PATIENT_STATUS,CLAIM_STATUS,PROCESSING_STATUS,CLAIM_TYPE,TOTAL_BILLED_AMT,TOTAL_PAID_AMT,SrcAdiTableName,SrcAdiKey,LoadDate,CreatedDate,CreatedBy,LastUpdatedDate,LastUpdatedBy,CalcdTotalBilledAmount,BENE_PTNT_STUS_CD,DISCHARGE_DISPO")] Claims_Headers claims_Headers)
        {
            if (ModelState.IsValid)
            {
                db.Claims_Headers.Add(claims_Headers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(claims_Headers);
        }

        // GET: Claims_Headers/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Claims_Headers claims_Headers = db.Claims_Headers.Find(id);
            if (claims_Headers == null)
            {
                return HttpNotFound();
            }
            return View(claims_Headers);
        }

        // POST: Claims_Headers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SEQ_CLAIM_ID,SUBSCRIBER_ID,CLAIM_NUMBER,CATEGORY_OF_SVC,PAT_CONTROL_NO,ICD_PRIM_DIAG,PRIMARY_SVC_DATE,SVC_TO_DATE,CLAIM_THRU_DATE,POST_DATE,CHECK_DATE,CHECK_NUMBER,DATE_RECEIVED,ADJUD_DATE,CMS_CertificationNumber,SVC_PROV_ID,SVC_PROV_FULL_NAME,SVC_PROV_NPI,PROV_SPEC,PROV_TYPE,PROVIDER_PAR_STAT,ATT_PROV_ID,ATT_PROV_FULL_NAME,ATT_PROV_NPI,REF_PROV_ID,REF_PROV_FULL_NAME,VENDOR_ID,VEND_FULL_NAME,IRS_TAX_ID,DRG_CODE,BILL_TYPE,ADMISSION_DATE,AUTH_NUMBER,ADMIT_SOURCE_CODE,ADMIT_HOUR,DISCHARGE_HOUR,PATIENT_STATUS,CLAIM_STATUS,PROCESSING_STATUS,CLAIM_TYPE,TOTAL_BILLED_AMT,TOTAL_PAID_AMT,SrcAdiTableName,SrcAdiKey,LoadDate,CreatedDate,CreatedBy,LastUpdatedDate,LastUpdatedBy,CalcdTotalBilledAmount,BENE_PTNT_STUS_CD,DISCHARGE_DISPO")] Claims_Headers claims_Headers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(claims_Headers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(claims_Headers);
        }

        // GET: Claims_Headers/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Claims_Headers claims_Headers = db.Claims_Headers.Find(id);
            if (claims_Headers == null)
            {
                return HttpNotFound();
            }
            return View(claims_Headers);
        }

        // POST: Claims_Headers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Claims_Headers claims_Headers = db.Claims_Headers.Find(id);
            db.Claims_Headers.Remove(claims_Headers);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
