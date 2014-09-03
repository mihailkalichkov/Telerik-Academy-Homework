using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework2
{
    public class Version : System.Attribute
    {
        public string ProductVersion { get; private set; }

        public Version(string version)
        {
            this.ProductVersion = version;
        }
    }
}