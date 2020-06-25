using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YourMoneyScript : MonoBehaviour
{

    public static int moneyValue = 0;
    Text money;
    // Start is called before the first frame update
    void Start()
    {
        money = GetComponent<Text>();
        //money.text = 0+"";

    }

    // Update is called once per frame
    public static void ChangeYourMoneyText(int playerNowMoney)
    {
        moneyValue = playerNowMoney;
    }
    void Update()
    {
        //money.text = "חש " + moneyValue;
        if(PlayersList.playerthatNowPlaying>=0)
            money.text = "חש " + PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].GetComponent<PlayerAccount>().playerMoney;

    }
}
