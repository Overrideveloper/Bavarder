using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.IO;
using Bavarder.Models;

namespace Bavarder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public FileContentResult UserPhoto()
        {
                String userId = User.Identity.GetUserId();
                var dbUsers = new ApplicationDbContext();
                var userImage = dbUsers.Users.Where(s => s.Id == userId).FirstOrDefault();

                if (userImage.UserPhoto == null)
                {
                    string fileName = HttpContext.Server.MapPath(@"~/Images/user.png");
                    byte[] imageData = null;
                    FileInfo fileInfo = new FileInfo(fileName);
                    long imageFileLength = fileInfo.Length;
                    FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    imageData = br.ReadBytes((int)imageFileLength);
                    return File(imageData, "image/png");
                }
                else
                {
                    return new FileContentResult(userImage.UserPhoto, "image/png");
                }
        }
    }
}