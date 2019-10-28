using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExtentions.Common.Base.Message
{
    public interface IMessageObject : IObject
    {

        bool IsMessageVisible();
        string AlertMessage { get; }
        void ClickOkButton();

    }
}
