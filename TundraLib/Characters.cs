using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TundraLib
{
    public class CharInfo
    {
        public string Character;

        public CharInfo(string Character)
        {
            this.Character = Character;
        }
    }

    public class SmartReplaceInfo
    {
        public string Start;
        public string Finish;

        public SmartReplaceInfo(string Start, string Finish)
        {
            this.Start = Start;
            this.Finish = Finish;
        }
    }

    public static class Characters
    {
        public static List<CharInfo> Accents = new List<CharInfo>();
        public static List<CharInfo> Affricates = new List<CharInfo>();
        public static List<CharInfo> Common = new List<CharInfo>();
        public static List<CharInfo> Consonants = new List<CharInfo>();
        public static List<CharInfo> Other = new List<CharInfo>();
        public static List<SmartReplaceInfo> SmartReplace = new List<SmartReplaceInfo>();
        public static List<CharInfo> ToneIntonation = new List<CharInfo>();
        public static List<CharInfo> Vowels = new List<CharInfo>();

    }
}
