using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace gzdemo
{
    // 引入一些WINDOWS的API供 C# 使用
    class pubfunc
    {
        [DllImport("KERNEL32.DLL")]
        public static extern int GetPrivateProfileSection(string lpAppName, byte[] lpReturnedString, int nSize,string lpFileName);
        [DllImport("KERNEL32.DLL")]
        private static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("KERNEL32.DLL")]
        private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retVal, int size, string filePath);
        [DllImport("KERNEL32.DLL")]
        private static extern int GetPrivateProfileInt(string section, string key,  int nDefault, string filePath);

    }
}
