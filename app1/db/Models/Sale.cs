﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace app1.db.Models;

public partial class Sale
{
    public string StorId { get; set; }

    public string OrdNum { get; set; }

    public DateTime OrdDate { get; set; }

    public short Qty { get; set; }

    public string Payterms { get; set; }

    public string TitleId { get; set; }

    public virtual Store Stor { get; set; }

    public virtual Title Title { get; set; }
}