using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItScript : MonoBehaviour
{

    public void BuyAsset()
    {

        if (AllAssets_Tiles.getTilesList()[PlayersList.GetCurrentTileOfplayerthatNowPlaying()].owner==-1)
        {
            if (PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].GetComponent <PlayerAccount>().playerMoney- AllAssets_Tiles.getTilesList()[PlayersList.GetCurrentTileOfplayerthatNowPlaying()].tileBuyingPrice>0)
            {
                PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].GetComponent<PlayerAccount>().playerMoney -= AllAssets_Tiles.getTilesList()[PlayersList.GetCurrentTileOfplayerthatNowPlaying()].tileBuyingPrice;
                PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].GetComponent<PlayerAccount>().playerAssets.Add(AllAssets_Tiles.getTilesList()[PlayersList.GetCurrentTileOfplayerthatNowPlaying()]);
                AllAssets_Tiles.getTilesList()[PlayersList.GetCurrentTileOfplayerthatNowPlaying()].owner = PlayersList.playerthatNowPlaying;
            }
        }
        //if (AllAssets_Tiles.getTilesList()[PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].GetComponent<Player_Movement>.()])
        /*
        if (YourMoneyScript.moneyValue - TileBuyingPriceScript.tileBuyingPriceValue > 0)
            YourMoneyScript.moneyValue = YourMoneyScript.moneyValue - TileBuyingPriceScript.tileBuyingPriceValue;
        PlayerAccount.addAsset(AllAssets_Tiles.getTilesList()[PlayersList.listOfPlayers[PlayersList.playerTurn].GetComponent<Player_Movement>().playerCurrentTile]);
   */
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

  
}
