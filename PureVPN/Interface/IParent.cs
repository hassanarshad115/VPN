using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PureVPN.Interface
{
    public interface IParent
    {
        Form ParentForm { get; set; }
    }
}
