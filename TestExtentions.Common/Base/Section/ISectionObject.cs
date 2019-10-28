using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExtentions.Common.Base;
using TestExtentions.Common.Base.Message;

namespace TestExtentions.Common.Base.Section
{
    interface ISectionObject : IObject
    {
        IMessageObject MessageObject { get; set; }
    }
}
