﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ConsoleLinq.Models.Pubs;

public partial class publisher
{
    public string pub_id { get; set; }

    public string pub_name { get; set; }

    public string city { get; set; }

    public string state { get; set; }

    public string country { get; set; }

    public virtual ICollection<employee> employees { get; set; } = new List<employee>();

    public virtual pub_info pub_info { get; set; }

    public virtual ICollection<title> titles { get; set; } = new List<title>();
}