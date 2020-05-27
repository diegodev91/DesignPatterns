using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Components
{
    public class Component1 : BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("Component 1 does A.");
            this.mediator.Notify(this, "A");
        }

        public void Dob()
        {
            Console.WriteLine("Component 1 does B.");
            this.mediator.Notify(this, "B");
        }
    }
}
