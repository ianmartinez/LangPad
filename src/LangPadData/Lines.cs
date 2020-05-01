using System;
using System.Collections.Generic;
using System.Text;

namespace LangPadData
{
    public static class Lines
    {
        public static string[] Get(string data)
        {
            return data.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
