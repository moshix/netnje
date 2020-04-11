﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using netnje.Structures;

namespace netnje
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log.InfoFormat("Starting netnje version {0}", typeof(Program).Assembly.GetName().Version);

            foreach (var name in Assembly.GetExecutingAssembly().GetManifestResourceNames())
            {
                log.InfoFormat("Embedded resource: {0}", name);
            }

            //NjeClient client = new NjeClient("UKYJVMS", "FRYJLX1", "bsdm.yvanj.me", 175);
            //client.Connect();

            ControlRecord controlRecord = new ControlRecord("OPEN", "UKYJVMS", "127.0.0.1", "FRYJLX1", "bsdm.yvanj.me", 0);

            byte[] result = controlRecord.GetBytes();

            Console.WriteLine("Hit enter");
            Console.ReadLine();
        }
    }
}
