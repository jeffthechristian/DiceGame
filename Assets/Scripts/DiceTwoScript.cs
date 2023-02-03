using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceTwoScript : MonoBehaviour
{
    public static int result;

    private void OnTriggerStay(Collider col)
    {
        switch (col.gameObject.name)
        {
            case "One1":
                result = 1;
                break;
            case "Two1":
                result = 2;
                break;
            case "Three1":
                result = 3;
                break;
            case "Four1":
                result = 4;
                break;
            case "Five1":
                result = 5;
                break;
            case "Six1":
                result = 6;
                break;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        result = 0;
    }
}