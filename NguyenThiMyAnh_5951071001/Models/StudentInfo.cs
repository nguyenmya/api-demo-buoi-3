using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NguyenThiMyAnh_5951071001.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "maSV")]
        public string MaSV { get; set; }
        [DataMember(Name = "ten")]
        public string Ten { get; set; }
    }

}