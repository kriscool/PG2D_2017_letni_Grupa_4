using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game4.MyEventArgs
{
    public class NewInputEventArgs : EventArgs
    {
        public Input Input { get; set; }

        public NewInputEventArgs(Input input)
        {
            Input = input;
        }
    }
}