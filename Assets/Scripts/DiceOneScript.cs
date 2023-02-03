using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceOneScript : MonoBehaviour
{
    public static int result;

    private void OnTriggerStay(Collider col)
    {
        switch (col.gameObject.name)
        {
            case "One":
                result = 1;
                break;
            case "Two":
                result = 2;
                break;
            case "Three":
                result = 3;
                break;
            case "Four":
                result = 4;
                break;
            case "Five":
                result = 5;
                break;
            case "Six":
                result = 6;
                break;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        result = 0;
    }
}