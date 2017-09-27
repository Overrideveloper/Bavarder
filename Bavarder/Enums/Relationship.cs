using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bavarder.Enums
{
    public enum Relationship
    {
        [Description("Single")]
        Single,
        [Description("In a relationship")]
        InARelationship,
        [Description("Engaged")]
        Engaged,
        [Description("Married")]
        Married,
        [Description("It's complicated")]
        ItsComplicated
    }
}