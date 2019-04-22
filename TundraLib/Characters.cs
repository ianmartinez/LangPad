using System.Collections.Generic;
using System.Linq;

namespace TundraLib
{
    public class CharacterInfo
    {
        public string Description;
        public string Character;
        public CharacterType Type;
        public bool MultiLine;

        public CharacterInfo(string character, string description, CharacterType type, bool multiline)
        {
            Character = character;
            Description = description;
            Type = type;
            MultiLine = multiline;
        }

        public bool IsIPA
        {
            get
            {
                var IPATypes = new CharacterType[] {
                CharacterType.IPAConsonant,
                CharacterType.IPAAffricate,
                CharacterType.IPAVowel,
                CharacterType.IPATone,
                CharacterType.IPADiacritic,
                CharacterType.IPASuprasegmental};

                return IPATypes.Contains(Type);
            }
        }
    }

    public enum CharacterType
    {
        All,
        ExtendedLatin,
        ExtendedCyrillic,
        ExtendedGreek,
        IPAAll,
        IPAConsonant,
        IPAAffricate,
        IPAVowel,
        IPATone,
        IPADiacritic,
        IPASuprasegmental
    }

    public class CharacterSearch
    {
        public static List<CharacterInfo> Characters;

        public CharacterSearch()
        {
            Characters = new List<CharacterInfo>();
        }

        public CharacterInfo[] Search(string query, CharacterType type)
        {
            var queryMatch = from _char in Characters where _char.Description.ToLower().Contains(query.ToLower()) select _char;
            
            switch (type)
            {
                case CharacterType.All:
                    return queryMatch.ToArray();
                case CharacterType.IPAAll:
                    return (from _char in queryMatch where _char.IsIPA select _char).ToArray();
                default:
                    return (from _char in queryMatch where (_char.Type == type) select _char).ToArray();

            }
        }

        public void Add(string character, string description, CharacterType type, bool multiline)
        {
            Characters.Add(new CharacterInfo(character, description, type, multiline));
        }
    }
}
