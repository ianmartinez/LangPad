using System;
using System.Collections.Generic;
using System.Text;
using LangPadData;

namespace LangPad
{
    public static class App
    {
        private static string dataFolder = null;
        public static string DataFolder
        {
            get
            {
                if(dataFolder == null)
                    dataFolder = TempFolder.GetNewTempFolderRoot(TempFolderType.AppData);

                return dataFolder;
            }
        }
    }
}
