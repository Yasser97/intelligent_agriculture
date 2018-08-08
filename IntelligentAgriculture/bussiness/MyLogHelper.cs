﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntelligentAgriculture.Bussiness
{
    public class MyLogHelper
    {
        private static Logger log = LogManager.GetLogger("DefaultLog");
        public static void Error(object msg, Exception exp = null)
        {
            if (exp == null)
                log.Error("#" + msg);
            else
                log.Error("#" + msg + "  " + exp.ToString());
        }

        public static void Debug(object msg, Exception exp = null)
        {
            if (exp == null)
                log.Debug("#" + msg);
            else
                log.Debug("#" + msg + "  " + exp.ToString());
        }

        public static void Fatal(object msg, Exception exp = null)
        {
            if (exp == null)
                log.Fatal("#" + msg);
            else
                log.Fatal("#" + msg + "  " + exp.ToString());
        }

        public static void Info(object msg, Exception exp = null)
        {
            if (exp == null)
                log.Info("#" + msg);
            else
                log.Info("#" + msg + "  " + exp.ToString());
        }


        public static void Warn(object msg, Exception exp = null)
        {
            if (exp == null)
                log.Warn("#" + msg);
            else
                log.Warn("#" + msg + "  " + exp.ToString());
        }
    }
}