using System;
using System.Collections.Generic;

namespace Boris.JasperLeonard.Web.Models
{
    public class SlideshowModel
    {
        public List<string> ImagePaths { get; set; }
        public String ShowName { get; set; }
        public List<string> SlideshowNames { get; set; }
        public string NewShowName { get; set; }
    }
}