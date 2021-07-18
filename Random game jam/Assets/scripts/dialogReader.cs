using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class dialogReader : MonoBehaviour
{
    public TextMeshProUGUI display;
    public string displayedText;
    private dialogNode currentNode;
    private float textDelay;
    [SerializeField]
    private float defaltTextDelay;
    [SerializeField]
    public float fastTextDelay;

    public IEnumerator read()
    {
        textDelay = defaltTextDelay;
        char[] currentPassedText = currentNode.Text.ToCharArray();
        //loops through all the charicters in the current dialog nodes text and displays them with delay
        for (int i = 0; i < currentPassedText.Length; i++)
        {
            displayedText += currentPassedText[i];
            yield return new WaitForSeconds(textDelay);
        }
        
    }
    public void speedRead()
    {
        textDelay = fastTextDelay;
    }
    public void displayNextOption()
    {
        //loop through the contiue options and display them alowing them to pick an option
    }
}
