using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItScript : MonoBehaviour
{

    public void BuyAsset()
    {
        if (YourMoneyScript.moneyValue - TileBuyingPriceScript.tileBuyingPriceValue > 0)
            YourMoneyScript.moneyValue = YourMoneyScript.moneyValue - TileBuyingPriceScript.tileBuyingPriceValue;
        PlayerAccount.addAsset(AllAssets_Tiles.getTilesList()[Player_Movement.playerCurrentTile]);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
