﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServer.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "age")]
        public int Age { get; set; }
    }
}