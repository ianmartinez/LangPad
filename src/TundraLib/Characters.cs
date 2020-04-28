using System;
using System.Collections.Generic;
using System.Linq;

namespace LangPadSupport
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
        IPASuprasegmental,
        Bracket
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
            var terms = query.ToLower().Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            var queryMatches = new List<CharacterInfo>();

            foreach (var _term in terms)
            {
                foreach (var _char in Characters)
                {
                    // If a match is found and the character hasn't been added yet
                    if (_char.Description.ToLower().Contains(_term) 
                        && (queryMatches.Count((existingChar) => (existingChar.Description == _char.Description && existingChar.Character == _char.Character)) == 0))
                    {
                        queryMatches.Add(_char);
                    }
                }
            }
            switch (type)
            {
                case CharacterType.All:
                    return queryMatches.ToArray();
                case CharacterType.IPAAll:
                    return (from _char in queryMatches where _char.IsIPA select _char).ToArray();
                default:
                    return (from _char in queryMatches where (_char.Type == type) select _char).ToArray();

            }
        }

        public void Add(string character, string description, CharacterType type, bool multiline)
        {
            Characters.Add(new CharacterInfo(character, description, type, multiline));
        }
    }
}
