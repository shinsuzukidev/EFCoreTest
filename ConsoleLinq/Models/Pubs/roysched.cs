﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ConsoleLinq.Models.Pubs;

public partial class roysched
{
    public string title_id { get; set; }

    public int? lorange { get; set; }

    public int? hirange { get; set; }

    public int? royalty { get; set; }

    public virtual title title { get; set; }
}