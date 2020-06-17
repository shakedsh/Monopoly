using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TileBuyingPriceScript : MonoBehaviour
{
    public static int tileBuyingPriceValue = 0;
    Text tileBuyingPrice;
    // Start is called before the first frame update
    void Start()
    {
        tileBuyingPrice = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tileBuyingPrice.text = "חש " + tileBuyingPriceValue;
    }
}
