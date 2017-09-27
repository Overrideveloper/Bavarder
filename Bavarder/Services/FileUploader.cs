using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Bavarder.Enums;

namespace Bavarder.Services
{
    public class FileUploader
    {
        public string UploadFile(HttpPostedFileBase fileUpload, UploadType uploadType, string UserId)
        {
            var fileName = DateTime.Now.ToFileTime().ToString();

            if (fileUpload != null)
            {
                var fileInfo = new FileInfo(fileUpload.FileName);
                if (fileInfo.Extension.ToLower() == ".jpg" || fileInfo.Extension.ToLower() == ".jpeg" || fileInfo.Extension.ToLower() == ".png")
                {
                    try
                    {
                        var fileExtension = fileInfo.Extension;

                        fileName = DateTime.Now.ToFileTime() + fileExtension;
                        
                        //Create upload folder if not created
                        var uploadFolderPath = HttpContext.Current.Server.MapPath("~/UploadedFiles/" + uploadType + "/" + UserId);

                        //Create directory if not existing
                        if (!Directory.Exists(uploadFolderPath))
                            Directory.CreateDirectory(uploadFolderPath);

                        //Save file
                        var filePath = uploadFolderPath + "/" + fileName;
                        fileUpload.SaveAs(filePath);
                    }
                    catch (Exception ex)
                    {

                        ex.ToString();
                    }
                }
            }
            return fileName;
        }

        public bool ThumbnailCallback()
        {
            return false;
        }
    }
}