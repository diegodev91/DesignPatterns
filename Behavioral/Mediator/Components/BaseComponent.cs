using Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Components
{
    public class BaseComponent
    {
        protected IMediator mediator;

        public BaseComponent(IMediator mediator = null)
        {
            this.mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
