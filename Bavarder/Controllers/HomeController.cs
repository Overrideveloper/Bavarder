using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.IO;
using Bavarder.Models;
using System.Threading.Tasks;
using Bavarder.Services;

namespace Bavarder.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult UserProfile()
        {
            return View("Profile");
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult GeneralChat()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public ActionResult UpdateProfile(string uid)
        {
            var appDbContext = new ApplicationDbContext();
            var viewModel = appDbContext.Users.Find(uid);
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateProfile(ApplicationUser AppUser, HttpPostedFileBase UserPhoto)
        {
            if (UserPhoto != null)
            {
                var info = new FileInfo(UserPhoto.FileName);
                if (info.Extension.ToLower() == ".jpg" || info.Extension.ToLower() == ".jpeg" || info.Extension.ToLower() == ".png")
                {
                    //file format compatible
                }
                else
                {
                    ModelState.AddModelError("incompatible", "File format not supported");
                }
            }

            if (ModelState.IsValid)
            {
                if (UserPhoto != null && UserPhoto.FileName != "")
                {
                    AppUser.UserPhoto = new FileUploader().UploadFile(UserPhoto, Enums.UploadType.ProfileImage, User.Identity.GetUserId());
                }
                var appDB = new ApplicationDbContext();
                appDB.Entry(AppUser).State = System.Data.Entity.EntityState.Modified;
                appDB.SaveChanges();
                return RedirectToAction("UserProfile");
            }
            return View(AppUser);
        }
    }
}