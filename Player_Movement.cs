using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player_Movement : MonoBehaviour
{
    public Vector3 camPOSForPlayer = new Vector3();
    //public static float camROTValue = 0;
    public Vector3 oldPos;
    public Vector3 camROTForPlayer = new Vector3();

    public int player_Speed_Accelerator = 50;
    public int playerCurrentTile = 0;
    public int playerTargetTile = 0;
    public int curQuarter = 1;
    private void Start()
    {
        camPOSForPlayer = TransformFollower.camLOCValue;
        oldPos = transform.position;
        camROTForPlayer = new Vector3(23.9f, 0f, 0f);



}
// Update is called once per frame
public void Move()
    {

        if (PlayersList.CurrentplayerSituation == 2) //PlayerList said player need to move
        {

            if (playerCurrentTile < 11&&playerCurrentTile<playerTargetTile)
            {
                if (transform.position.x > AllAssets_Tiles.getTilesList()[playerCurrentTile+1].get_tilePOS().x)
                {
                    oldPos = transform.position;
                    transform.position += transform.forward * Time.deltaTime * player_Speed_Accelerator;
                    camPOSForPlayer.x += transform.position.x - oldPos.x;
                    //Debug.Log("  camPOSForPlayer.x  " + camPOSForPlayer.x);


                    //Debug.Log("playerNeedToMove is true");
                }
                else
                {
                    playerCurrentTile++;
                    //Debug.Log("playerCurrentTile" + playerCurrentTile);
                    if (playerCurrentTile==11)
                    {
                        transform.Rotate(0, transform.rotation.y+90, 0);
                        camROTForPlayer = new Vector3(23.9f, 90f, 0f);
                        camPOSForPlayer = new Vector3(-144.18f, 71.38f, 33.26f);
                      

                        curQuarter = 2;

                    }
                }

            }

            else if (playerCurrentTile < 18 && playerCurrentTile < playerTargetTile)
            {
                //Debug.Log("firstplayerCurrentTile" + playerCurrentTile);
            

                if (transform.position.z < AllAssets_Tiles.getTilesList()[playerCurrentTile + 1].get_tilePOS().z)
                {
                    oldPos = transform.position;
                    transform.position += transform.forward * Time.deltaTime * player_Speed_Accelerator;
                    camPOSForPlayer.z += transform.position.x - oldPos.x;

                }
                else
                {
                    playerCurrentTile++;
                    Debug.Log("playerCurrentTile" + playerCurrentTile);
                    if (playerCurrentTile == 18)
                    {
                        transform.Rotate(0, transform.rotation.y + 90, 0);
                        camROTForPlayer = new Vector3(23.9f, 180f, 0f);
                        camPOSForPlayer = new Vector3(6.7f, 76.4f, 221.4f);

                        curQuarter = 3;

                    }
                }

            }
            else if (playerCurrentTile < 29 && playerCurrentTile < playerTargetTile)
            {
                if (transform.position.x < AllAssets_Tiles.getTilesList()[playerCurrentTile + 1].get_tilePOS().x)
                {

                    oldPos = transform.position;
                    transform.position += transform.forward * Time.deltaTime * player_Speed_Accelerator;
                    camPOSForPlayer.x += transform.position.x - oldPos.x;

                    //Debug.Log("playerNeedToMove is true");
                }
                else
                {

                    playerCurrentTile++;
                    if (playerCurrentTile == 29)
                    {
                        transform.Rotate(0, transform.rotation.y + 90, 0);
                        curQuarter = 4;

                    }
                }

            }
            else if (playerCurrentTile < 36 && ((playerCurrentTile < playerTargetTile)|| (playerCurrentTile>29&& playerTargetTile>0)))
            {
                Debug.Log("firstplayerCurrentTile" + playerCurrentTile);

                if (playerCurrentTile == 35)
                {
                    if (transform.position.z > AllAssets_Tiles.getTilesList()[0].get_tilePOS().z)
                        transform.position += transform.forward * Time.deltaTime * player_Speed_Accelerator;
                    else
                    {
                        oldPos = transform.position;
                        playerCurrentTile = 0;
                            transform.Rotate(0, transform.rotation.y + 90, 0);
                        curQuarter = 1;


                    }
                }
                else if (transform.position.z > AllAssets_Tiles.getTilesList()[playerCurrentTile + 1].get_tilePOS().z)
                {
                    oldPos = transform.position;
                    transform.position += transform.forward * Time.deltaTime * player_Speed_Accelerator;
                    camPOSForPlayer.z += transform.position.x - oldPos.x;

                    //Debug.Log("playerNeedToMove is true");
                }
                else
                {
                    playerCurrentTile++;
                    
                }

            }
            else
            {
                //playerCurrentTile += Dice_script.diceResult;
                PlayersList.CurrentplayerSituation = 0;
                PlayersList.nextPlayerTurn();
                //PlayersList.PaymentForOwner();
                CurrentTileUpdate(playerCurrentTile);
                Dice_script.moveDiceToNextPlayer = true;
            }

        }

        /*
        void path()
        {
            if(playerCurrentTile>0&&playerCurrentTile<7)// **need to rotate player in 0 tile aftet whole round**
            {

            }
        }
        */

        void CurrentTileUpdate(int playerCurrentTile) //need to change it
        {
            GroupScript.groupValue = AllAssets_Tiles.getTilesList()[playerCurrentTile].tileGroup;
            TileNameScript.tileNameValue = AllAssets_Tiles.getTilesList()[playerCurrentTile].tileName;
            TileBuyingPriceScript.tileBuyingPriceValue = AllAssets_Tiles.getTilesList()[playerCurrentTile].tileBuyingPrice;
            //OwnerScript.ownerValue = AllAssets_Tiles.getTilesList()[playerCurrentTile].owner;
        }
    }
}
