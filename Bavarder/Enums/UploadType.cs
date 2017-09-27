using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Bavarder.Enums
{
    public enum UploadType
    {
        [Description("Profile Image")]
        ProfileImage,
        [Description("Photo")]
        Photo
    }
}