using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{   

    [SerializeField] bool hasGlass;
    [SerializeField] bool knowTheKey;

    public bool GetGlassStatus()
    {
        return hasGlass;
    }

    public bool GetTheKeyStatus()
    {
        return knowTheKey;
    }
}
