using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AjaxWork.Models
{
    public class StudentModel
    {
        [Required (ErrorMessage ="Rquired")]
        public int studentID { get; set; }
        [Required(ErrorMessage = "Rquired")]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "Rquired")]
        public string  FatherName { get; set; }
        [Required(ErrorMessage = "Rquired")]
        public String  MotherName { get; set; }
        [Required(ErrorMessage = "Rquired")]
        public int Class { get; set; }
        [Required(ErrorMessage = "Rquired")]
        public string CellNo { get; set; }

    }
    public class AjaxResponse
    {
        public bool Response { get; set; }
        public string Message { get; set; }
    }
}