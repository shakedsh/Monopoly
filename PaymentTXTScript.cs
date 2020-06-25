using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaymentTXTScript : MonoBehaviour
{
    public static int moneyValue = 0;
    

    Text money;
    // Start is called before the first frame update
    void Start()
    {
        money = GetComponent<Text>();
        //money.text = 0+"";

    }

    // Update is called once per frame // CHECK IF IN USE
    public static void ChangeYourMoneyText(int playerNowMoney)
    {
        moneyValue = playerNowMoney;
    }
    void Update()
    {
        //money.text = "חש " + moneyValue;
       
        if (PlayersList.playerthatNowPlaying >= 0)
        {
            if (PlayersList.TransmitionSituation != 0)
            {
                if (PlayersList.TransmitionSituation == 2)
                    money.text = " :רוקיבה תולע " + "\n" + "חש " + AllAssets_Tiles.getTilesList()[PlayersList.GetCurrentTileOfplayerthatNowPlaying()].tiletransmitionPayment;
                else if (PlayersList.TransmitionSituation == 1)
                    money.text = " : תולע " + "\n" + "חש " + AllAssets_Tiles.getTilesList()[PlayersList.GetCurrentTileOfplayerthatNowPlaying()].tileBuyingPrice;
                else if (PlayersList.TransmitionSituation == 3)
                    money.text = " ראוד! ";
            }

        }
    }
}