using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace AjaxWork.Models
{
    public class TeacherModel
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string Address { get; set; } 
    }
}