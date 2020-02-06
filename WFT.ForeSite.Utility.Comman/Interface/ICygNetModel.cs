using System;
using System.Collections.Generic;
using System.Text;

namespace WFT.ForeSite.Utility.Comman.Interface
{
    public interface ICygNetModel
    {
        UInt16 Domain { get; set; }
        string Site { get; set; }
        string Service { get; set; }
    }
}
