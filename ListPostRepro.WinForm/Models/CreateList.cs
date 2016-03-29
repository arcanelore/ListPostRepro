using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPostRepro.WinForm.Models
{
    class CreateList
    {
        public string CreateListString { get; set; }

        public int CreateListInt { get; set; }

        public List<ListValueItem> ListValues { get; set; }
    }
}
