﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercice
{
    class SendNotification : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("sending new notification to this activity");
        }
    }
}
