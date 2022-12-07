using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStatus : MonoBehaviour
{

    [SerializeField] bool hasGlass;
    [SerializeField] bool knowTheKey;
    [SerializeField] bool hasLetter;
    [SerializeField] bool isLetterOpen;
    [SerializeField] GameObject letter;
    [SerializeField] TextMeshProUGUI letterPromt;

    private void Update()
    {
        ShowandCloseLetter();
    }

    public bool GetGlassStatus()
    {
        return hasGlass;
    }

    public bool GetTheKeyStatus()
    {
        return knowTheKey;
    }

    public bool GetTheLetterStatus()
    {
        return hasLetter;
    }

    public bool GetIsLetterOpen()
    {
        return isLetterOpen;
    }
    public void SetLetterStatus(bool newStatus)
    {
        hasLetter = newStatus;
    }

    public void ShowLetterTheFirstTime()
    {
        letter.SetActive(true);
        letterPromt.enabled = true;
        letterPromt.gameObject.SetActive(true);
        isLetterOpen = true;
    }

    void ShowandCloseLetter()
    {
        if (Input.GetKeyDown(KeyCode.C) && hasLetter)
        {
            if (!isLetterOpen)
            {
                letter.SetActive(true);
                letterPromt.enabled = true;
                letterPromt.gameObject.SetActive(true);
                isLetterOpen = true;
            }
            else if (isLetterOpen)
            {
                letter.SetActive(false);
                letterPromt.enabled = false;
                letterPromt.gameObject.SetActive(false);
                isLetterOpen = false;
            }
        }
    }
}
