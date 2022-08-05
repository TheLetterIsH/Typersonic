using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "sordid", "giddy", "swing", "zippy", "hug", "current", "texture", "cheap", "heavy", "calm", "powder", "geese", "fresh", "dime", "brick", 
        "handle", "bikes", "thread", "early", "tiny", "oven", "invite", "find", "chalk", "vanish", "plants", "sincere", "quilt", "include", "mess up", "cheer", 
        "laugh", "idea", "stupendous", "bouncy", "nutritious", "erect", "mysterious", "aboard", "sloppy", "different", "excited", "moaning", "didactic", "crime", "unaccountable", 
        "oafish", "learned", "vivacious", "oceanic", "groovy", "lock", "expect", "obsequious","cats", "materialistic", "hair", "highfalutin", "tickle", "lie", "practice", "flame", 
        "lip", "wheel", "zany", "shop", "vessel", "illustrious", "nose", "hot", "possessive", "elderly", "complete","melt", "simple", "compare", "stew", "ray", "flagrant", 
        "waste", "pricey", "colorful", "queen", "discover", "doubt", "five", "miss", "ruthless", "striped", "flower", "position", "righteous", "steadfast", "bomb", "shade", "van", 
        "flock", "return", "balance", "vacuous"};

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
