using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EssentialJS1WebApplication1.Models;

namespace EssentialJS1WebApplication1.Controllers
{
    public class FacilitiesController : Controller
    {
        private readonly MEDICALACCESSContext _context;

        public FacilitiesController(MEDICALACCESSContext context)
        {
            _context = context;
        }

        // GET: Facilities
        public IActionResult Facility()
        {
            ViewBag.datasource = _context.AFacilities().ToList();
            return View();
        }

        
        // GET: Facilities/Create
        public IActionResult Create()
        {
           return View();
        }

        // POST: Facilities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FacilityCode,DeliveryZoneCode,ImplimentingPartnerCode,DistrrictCode,Facility,SapCode,Supporte_contextyMaul,IsAccredited,LevelOfCare,ClientTypeCode,RegionCode,RfsoUserName,OwnershipId,CdcregionId,FacilityTypeId,Longtitude,Latititude,VillageId,ComprehensiveImplimentingPartnerCode,PatientLoadCode,IsActive,NearestPublicHfDistance,Dsdm,ActiveArt")] AFacilities aFacilities)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aFacilities);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CdcregionId"] = new SelectList(_context.ACdcregion, "CdcregionId", "CdcregionId", aFacilities.CdcregionId);
            ViewData["ClientTypeCode"] = new SelectList(_context.AClientType, "ClientTypeCode", "ClientTypeCode", aFacilities.ClientTypeCode);
            ViewData["ComprehensiveImplimentingPartnerCode"] = new SelectList(_context.AImplimentingPartners, "ImplimentingPartnerCode", "ImplimentingPartnerCode", aFacilities.ComprehensiveImplimentingPartnerCode);
            ViewData["DeliveryZoneCode"] = new SelectList(_context.ADeliveryZone, "ZoneCode", "ZoneCode", aFacilities.DeliveryZoneCode);
            ViewData["DistrrictCode"] = new SelectList(_context.ADistrict, "DistrictCode", "DistrictCode", aFacilities.DistrrictCode);
            ViewData["FacilityTypeId"] = new SelectList(_context.AFacilityType, "FacilityTypeId", "FacilityTypeId", aFacilities.FacilityTypeId);
            ViewData["LevelOfCare"] = new SelectList(_context.AFacilityLevelOfCare, "LevelOfCareCode", "LevelOfCareCode", aFacilities.LevelOfCare);
            ViewData["OwnershipId"] = new SelectList(_context.AOwnership, "OwnershipId", "OwnershipId", aFacilities.OwnershipId);
            ViewData["PatientLoadCode"] = new SelectList(_context.APatientLoad, "PatientLoadCode", "PatientLoadCode", aFacilities.PatientLoadCode);
            ViewData["VillageId"] = new SelectList(_context.AVillage, "VillageId", "VillageId", aFacilities.VillageId);
            return View(aFacilities);
        }

        
        private bool AFacilitiesExists(int id)
        {
            return _context.AFacilities.Any(e => e.FacilityCode == id);
        }

        //batch update saving   CRUDE OPERATION
        public IActionResult  Update(AFacilities value)
        {
             AFacilities table = _context.AFacilities.FirstOrDefault(o => o.FacilityCode == value.FacilityCode);
            value.updated_at = DateTime.Now;
            _context.Entry(table).CurrentValues.SetValues(value);
            _context.Entry(table).State = EntityState.Modified;
            _context.SaveChanges();

            Session["ActivityId"] = value.FacilityCode;
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public IActionResult  Insert(AFacilities value)
        {
             {
                _context.AFacilities.Add(value);

                try
                {
                    _context.SaveChanges();
                    //
                    TempData["FacilityCode"] = value.FacilityCode;
                    TempData["Success"] = "Record Saved Successfully!";
                    int mynumber = value.FacilityCode;
                }
                catch (System.Data.Entity.Validation._contextEntityValidationException _contextEx)
                {
                    Exception raise = _contextEx;
                    foreach (var validationErrors in _contextEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
            }
            return RedirectToAction("Facility");
        }

        public IActionResult Delete(int key)
        {

            AFacilities result = _context.AFacilities.FirstOrDefault(o => o.FacilityCode == key);
            _context.AFacilities.Remove(result);
            _context.SaveChanges();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}
