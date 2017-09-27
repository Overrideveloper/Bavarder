using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Bavarder.Enums
{
    public enum Gender
    {
        [Description("Male")]
        Male,
        [Description("Female")]
        Female
    }
}