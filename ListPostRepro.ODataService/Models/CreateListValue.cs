using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ListPostRepro.ODataService.Models
{
    public class CreateListValue
    {
        [Key]
        public string CreateListString { get; set; }

        public int CreateListInt { get; set; }

        public List<ListValue> ListValues { get; set; }
    }
}