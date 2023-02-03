using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceFourScript : MonoBehaviour
{
    public static int result;

    private void OnTriggerStay(Collider col)
    {
        switch (col.gameObject.name)
        {
            case "One3":
                result = 1;
                break;
            case "Two3":
                result = 2;
                break;
            case "Three3":
                result = 3;
                break;
            case "Four3":
                result = 4;
                break;
            case "Five3":
                result = 5;
                break;
            case "Six3":
                result = 6;
                break;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        result = 0;
    }
}