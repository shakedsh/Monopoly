using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileNameScript : MonoBehaviour
{
    public static string tileNameValue = "NAME";
    Text tileName;
    // Start is called before the first frame update
    void Start()
    {
        tileName = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tileName.text = "" + tileNameValue;
    }
}
