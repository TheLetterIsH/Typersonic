using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordCanvas;

    public WordDisplay SpawnWord()
    {
        GameObject wordObject = Instantiate(wordPrefab, wordCanvas);
        WordDisplay wordDisplay = wordObject.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
