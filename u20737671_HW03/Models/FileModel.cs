using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20737671_HW03.Models
{
    public class FileModel
    {

        public string Filename { get; set; }

        public HttpPostedFileBase files { get; set; }

    }
}