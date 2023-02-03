using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceScript : MonoBehaviour
{
    Rigidbody rb;
    public static Vector3 randomRotation;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        float randomForce = Random.Range(0.5f, 2.8f);
        randomRotation = new Vector3(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));
        rb.AddForce(Vector3.up * randomForce, ForceMode.Impulse);
        rb.AddTorque(randomRotation, ForceMode.Impulse);
    }

    public void RollDices()
    {
        float randomForce = Random.Range(0.5f, 2.8f);
        randomRotation = new Vector3(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));
        rb.AddForce(Vector3.up * randomForce, ForceMode.Impulse);
        rb.AddTorque(randomRotation, ForceMode.Impulse);
    }
}