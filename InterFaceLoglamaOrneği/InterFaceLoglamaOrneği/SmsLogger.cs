﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceLoglamaOrneği
{
    class SmsLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("SMS kaydı yapıldı.");
        }
    }
}
