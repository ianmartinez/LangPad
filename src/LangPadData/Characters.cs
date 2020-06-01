using System;
using System.Collections.Generic;
using System.Linq;

namespace LangPadData
{
    /// <summary>
    /// Contains info about a character in the character editor.
    /// </summary>
    public class CharacterInfo
    {
        /// <summary>
        /// The character to be inserted.
        /// </summary>
        public string Character { get; set; }

        /// <summary>
        /// The description displayed in the tooltip.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The type of chracter to be inserted.
        /// </summary>
        public CharacterType Type { get; set; }

        /// <summary>
        /// If the description is multiline.
        /// </summary>
        public bool MultiLine { get; set; }

        public CharacterInfo(string character, string description, CharacterType type, bool multiline)
        {
            Character = character;
            Description = description;
            Type = type;
            MultiLine = multiline;
        }

        /// <summary>
        /// If the character in question is part of the IPA (International Phonetic Alphabet).
        /// </summary>
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
                    CharacterType.IPASuprasegmental
                };

                return IPATypes.Contains(Type);
            }
        }
    }

    /// <summary>
    /// The type of character to be inserted with the character
    /// editor.
    /// </summary>
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

    /// <summary>
    /// Search for a character out of a list of chracters.
    /// </summary>
    public class CharacterSearch
    {
        public static List<CharacterInfo> Characters;

        public CharacterSearch()
        {
            Characters = new List<CharacterInfo>();
        }

        /// <summary>
        /// Search for a character matching a query out of a given type of characters.
        /// Multiple queries can be combined with the '/' character.
        /// </summary>
        /// 
        /// <param name="query">The query string.</param>
        /// <param name="type">The type of character to find.</param>
        /// 
        /// <returns>All characters of the given type that match the query string.</returns>
        public CharacterInfo[] Search(string query, CharacterType type)
        {
            var terms = query.ToLower().Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            var queryMatches = new List<CharacterInfo>();

            // Search for each query term and find the charcters that match it.
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

            // Find the chracters fromt the query results that are in the type that is
            // wanted and return the result
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

        /// <summary>
        /// Add a character to the search list so that it can show up in search results.
        /// </summary>
        public void Add(string character, string description, CharacterType type, bool multiline)
        {
            Characters.Add(new CharacterInfo(character, description, type, multiline));
        }
    }
}
