using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bavarder.Enums
{
    public enum Relationship
    {
        [Display(Name = "Single")]
        Single,
        [Display(Name = "In a relationship")]
        InARelationship,
        [Display(Name = "Engaged")]
        Engaged,
        [Display(Name = "Married")]
        Married,
        [Display(Name = "It's complicated")]
        ItsComplicated
    }
}