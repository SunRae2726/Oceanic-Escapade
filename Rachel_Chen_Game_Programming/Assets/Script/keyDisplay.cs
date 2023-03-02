using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyDisplay : MonoBehaviour
{
    public inventory playerInventory;
    Text textbox;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = playerInventory.keys.ToString() + "/5";
    }
}
