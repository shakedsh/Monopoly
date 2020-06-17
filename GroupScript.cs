using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GroupScript : MonoBehaviour
{
    public static string groupValue = "GROUP";
    Text group;
    // Start is called before the first frame update
    void Start()
    {
        group = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        group.text = "" + groupValue;
    }
}
