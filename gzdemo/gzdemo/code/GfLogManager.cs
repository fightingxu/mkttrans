using System;
using System.Collections.Generic;
using System.Linq;
using log4net;
using System.Text;

namespace gzdemo.code
{
    class GfLogManager
    {
         public static FormMain LogRecoder = null;


        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// 记录日志(前后台)
        /// </summary>
        /// <param name="msg">信息内容</param>
        /// <param name="type">0:信息 1:错误</param>
        /// ADD BY XJF TEST测试
        public static void WriteLog(String msg, int type)
        {
            AddFrontLog(msg, type);
            switch (type)
            {
                case 0:
                    logger.Info(msg);
                    break;
                case 1:
                    logger.Error(msg);
                    break;
            }
        }

        public static void AddFrontLog(String log, int type)
        {
            if (LogRecoder != null)
                LogRecoder.AddFrontLog(log, type);
        }
    }
}
