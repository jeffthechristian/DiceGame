using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceSixScript : MonoBehaviour
{
    public static int result;

    private void OnTriggerStay(Collider col)
    {
        switch (col.gameObject.name)
        {
            case "One5":
                result = 1;
                break;
            case "Two5":
                result = 2;
                break;
            case "Three5":
                result = 3;
                break;
            case "Four5":
                result = 4;
                break;
            case "Five5":
                result = 5;
                break;
            case "Six5":
                result = 6;
                break;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        result = 0;
    }
}