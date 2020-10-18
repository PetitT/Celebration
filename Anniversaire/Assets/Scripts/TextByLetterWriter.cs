using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public static class TextByLetterWriter
{
    public static IEnumerator WriteText(Text text, string textToWrite, float timeBetweenLetters)
    {
        char[] charArray = textToWrite.ToCharArray();
        string completeText = "";
        for (int i = 0; i < charArray.Length; i++)
        {
            completeText = completeText + charArray[i];
            text.text = completeText;
            yield return new WaitForSeconds(timeBetweenLetters);
        }
    }

    public static IEnumerator WriteText(TextMeshPro text, string textToWrite, float timeBetweenLetters)
    {
        char[] charArray = textToWrite.ToCharArray();
        string completeText = "";
        for (int i = 0; i < charArray.Length; i++)
        {
            completeText = completeText + charArray[i];
            text.text = completeText;
            yield return new WaitForSeconds(timeBetweenLetters);
        }
    }

    public static IEnumerator WriteText(TextMesh text, string textToWrite, float timeBetweenLetters)
    {
        char[] charArray = textToWrite.ToCharArray();
        string completeText = "";
        for (int i = 0; i < charArray.Length; i++)
        {
            completeText = completeText + charArray[i];
            text.text = completeText;
            yield return new WaitForSeconds(timeBetweenLetters);
        }
    }

    public static IEnumerator WriteText(TextMeshProUGUI text, string textToWrite, float timeBetweenLetters)
    {
        char[] charArray = textToWrite.ToCharArray();
        string completeText = "";
        for (int i = 0; i < charArray.Length; i++)
        {
            completeText = completeText + charArray[i];
            text.text = completeText;
            yield return new WaitForSeconds(timeBetweenLetters);
        }
    }

}
