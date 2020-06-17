using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player_Movement : MonoBehaviour
{
    public int player_Speed_Accelerator = 50;
    public static float playerSituation = -1; // -1= game hasent started, 0= playerCharacter was mooving to his new place, 1= player need to move
    public static int playerCurrentTile=0;

    // Update is called once per frame
    void Update()
    {

        if (playerSituation==1) //if player need to move
        {
            if (transform.position.x > AllAssets_Tiles.getTilesList()[playerCurrentTile+Dice_script.diceResult].get_tilePOS().x)
            {
                  transform.position += transform.forward * Time.deltaTime*player_Speed_Accelerator;
                //Debug.Log("playerNeedToMove is true");
            }
            else
            {
                playerCurrentTile += Dice_script.diceResult;
                playerSituation = 0;
                CurrentTileUpdate(playerCurrentTile);
            }
        }
        

    }
    
    void CurrentTileUpdate(int playerCurrentTile)
    {
        GroupScript.groupValue = AllAssets_Tiles.getTilesList()[playerCurrentTile].tileGroup;
        TileNameScript.tileNameValue = AllAssets_Tiles.getTilesList()[playerCurrentTile].tileName;
        TileBuyingPriceScript.tileBuyingPriceValue = AllAssets_Tiles.getTilesList()[playerCurrentTile].tileBuyingPrice;
    }
}
