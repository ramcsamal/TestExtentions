using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExtentions.Common.Base.Message;

namespace TestExtentions.Common.Base.Page
{
    public interface IPageObject :IObject
    {
        IMessageObject MessageObject { get; set; }
    }
}
