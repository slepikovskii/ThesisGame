using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacktoBedroom : MonoBehaviour
{
    public string backToBedroom;

    public void ToBedroom()
    {
        Application.LoadLevel(backToBedroom);
    }
 
}
