using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YourMoneyScript : MonoBehaviour
{

    public static int moneyValue = 4;
    Text money;
    // Start is called before the first frame update
    void Start()
    {
        money = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        money.text ="חש "+moneyValue;
    }
}
