using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ListPostRepro.ODataService.Models
{
    public class ListValue
    {
        [Key]
        public string ListString { get; set; }

        public int ListInt { get; set; }
    }
}