using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceFiveScript : MonoBehaviour
{
    public static int result;

    private void OnTriggerStay(Collider col)
    {
        switch (col.gameObject.name)
        {
            case "One4":
                result = 1;
                break;
            case "Two4":
                result = 2;
                break;
            case "Three4":
                result = 3;
                break;
            case "Four4":
                result = 4;
                break;
            case "Five4":
                result = 5;
                break;
            case "Six4":
                result = 6;
                break;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        result = 0;
    }
}