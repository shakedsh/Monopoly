using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerAccount : MonoBehaviour
{

    string playerName;
    static int playerMoney=2000;
    static List<Asset_tile> playerAssets = new List<Asset_tile>(); //i need to change it to non static when i will be able to create players

  


    // Start is called before the first frame update
    void Start()
    {
        playerName = "יוסי";
        //playerAssets = new List<Asset_tile>();
        YourMoneyScript.moneyValue = playerMoney;
        //addAsset(AllAssets_Tiles.getTilesList()[1]);
        //addAsset(AllAssets_Tiles.getTilesList()[2]);
        //playerAssets.Add(AllAssets_Tiles.getTilesList()[1]);
        //playerAssets.Add(AllAssets_Tiles.getTilesList()[2]);
    }   

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void addAsset(Asset_tile assetNew)
    {
        playerAssets.Add(assetNew);
    }


    public static void setPlayerMoney(int moneyNew)
    {
        playerMoney = moneyNew;
        YourMoneyScript.moneyValue = playerMoney; //update the UI script
    }

    public static int getPlayerMoney()
    { return playerMoney; }
        
     

}
