using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Sample.View
{
    public interface IRectangle
    {
        string lengthText { get; set; }
        string widthText { get; set; }
        string resultText { get; set; }
    }
}
