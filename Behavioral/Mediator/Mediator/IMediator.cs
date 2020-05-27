using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Mediator
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
