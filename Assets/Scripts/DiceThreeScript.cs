using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceThreeScript : MonoBehaviour
{
    public static int result;

    private void OnTriggerStay(Collider col)
    {
        switch (col.gameObject.name)
        {
            case "One2":
                result = 1;
                break;
            case "Two2":
                result = 2;
                break;
            case "Three2":
                result = 3;
                break;
            case "Four2":
                result = 4;
                break;
            case "Five2":
                result = 5;
                break;
            case "Six2":
                result = 6;
                break;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        result = 0;
    }
}