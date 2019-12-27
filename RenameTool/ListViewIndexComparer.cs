using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameTool
{
    public class ListViewIndexComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((ListViewItem)x).Index - ((ListViewItem)y).Index;
        }
    }
}
