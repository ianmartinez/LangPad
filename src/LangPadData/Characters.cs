using System;
using System.Collections.Generic;
using System.Linq;

namespace LangPadData;

/// <summary>
/// Contains info about a character in the character editor.
/// </summary>
public class CharacterInfo(string character, string description, CharacterType type, bool multiline)
{
    /// <summary>
    /// The character to be inserted.
    /// </summary>
    public string Character { get; set; } = character;

    /// <summary>
    /// The description displayed in the tooltip.
    /// </summary>
    public string Description { get; set; } = description;

    /// <summary>
    /// The type of chracter to be inserted.
    /// </summary>
    public CharacterType Type { get; set; } = type;

    /// <summary>
    /// If the description is multiline.
    /// </summary>
    public bool MultiLine { get; set; } = multiline;

    /// <summary>
    /// If the character in question is part of the IPA (International Phonetic Alphabet).
    /// </summary>
    public bool IsIPA
    {
        get
        {
            CharacterType[] IPATypes = [
                  CharacterType.IPAConsonant,
                  CharacterType.IPAAffricate,
                  CharacterType.IPAVowel,
                  CharacterType.IPATone,
                  CharacterType.IPADiacritic,
                  CharacterType.IPASuprasegmental
              ];

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

    public CharacterSearch() => Characters = [];

    /// <summary>
    /// Search for a character matching a query out of a given type of characters.
    /// Multiple queries can be combined with the '/' character.
    /// </summary>
    /// 
    /// <param name="query">The query string.</param>
    /// <param name="type">The type of character to find.</param>
    /// 
    /// <returns>All characters of the given type that match the query string.</returns>
    public static CharacterInfo[] Search(string query, CharacterType type)
    {
        var terms = query.ToLower().Split(["/"], StringSplitOptions.RemoveEmptyEntries);
        var queryMatches = new List<CharacterInfo>();

        // Search for each query term and find the characters that match it.
        foreach (var term in terms)
        {
            foreach (var character in Characters)
            {
                // If a match is found and the character hasn't been added yet
                if (character.Description.Contains(term, StringComparison.CurrentCultureIgnoreCase)
                    && (!queryMatches.Any((existingChar) => (existingChar.Description == character.Description && existingChar.Character == character.Character))))
                {
                    queryMatches.Add(character);
                }
            }
        }

        // Find the chracters fromt the query results that are in the type that is
        // wanted and return the result
        return type switch
        {
            CharacterType.All => [.. queryMatches],
            CharacterType.IPAAll => [.. (from characater in queryMatches where characater.IsIPA select characater)],
            _ => [.. (from character in queryMatches where character.Type == type select character)],
        };
    }

    /// <summary>
    /// Add a character to the search list so that it can show up in search results.
    /// </summary>
    public static void Add(string character, string description, CharacterType type, bool multiline)
    {
        Characters.Add(new CharacterInfo(character, description, type, multiline));
    }
}
