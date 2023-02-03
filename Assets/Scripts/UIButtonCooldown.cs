using UnityEngine;
using UnityEngine.UI;

public class UIButtonCooldown : MonoBehaviour
{
    public float cooldownTime = 1f;
    private float timer;
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        timer = 0f;
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            button.interactable = false;
        }
        else
        {
            button.interactable = true;
        }
    }

    public void StartCooldown()
    {
        timer = cooldownTime;
    }
}