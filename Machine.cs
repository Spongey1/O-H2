using System;
using System.Collections.Generic;

namespace O_H2
{
    // Handles the creation of a Machine
    public class Machine
    {
        // All Components the Machine has
        List<string> Components = new List<string>();

        public Machine(List<string> components)
        {
            Components = components;
        }
    }
}