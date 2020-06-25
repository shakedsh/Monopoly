using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersList : MonoBehaviour
{


    public static List<GameObject> listOfPlayers = new List<GameObject>();
    public static int playersNum = 0; 
    public static int playerTurn = -1; // Who is the player whose turn to play -1 when the game hasnt started
    public static int playerthatNowPlaying = -1; // Who is the player that now playing (playerTurn switch after the movement -1 when the game hasnt started
    public static int CurrentplayerSituation = -1; //-1= game hasent started, 0= playerCharacter was mooving to his new place, 1= player need to move
    public static int TransmitionSituation=0; //0= dont do nothing, 1= player dont need to pay owner- show him asset details, 2=player need to pay owner, 3= player is on Mail tail
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("CurrentplayerSituation" + CurrentplayerSituation);
        if (CurrentplayerSituation == 1) //Request from dice to move player
        {
            CurrentplayerSituation = 2; //PlayersList knows that a player needs to be moved and asks the relevant player to move
            listOfPlayers[playerTurn].GetComponent<Player_Movement>().playerTargetTile = listOfPlayers[playerTurn].GetComponent<Player_Movement>().playerCurrentTile + Dice_script.diceResult;//update the tile target for the player
            if (listOfPlayers[playerTurn].GetComponent<Player_Movement>().playerTargetTile >= 36)//not working
                listOfPlayers[playerTurn].GetComponent<Player_Movement>().playerTargetTile -= 36;

        }
        if (CurrentplayerSituation == 2) //The player did not finish moving
            listOfPlayers[playerTurn].GetComponent<Player_Movement>().Move();




    }


    public static void nextPlayerTurn()
    {
        TransmitionSituation = TransmitionAction();
        playerTurn++;
        if (playerTurn == playersNum) //playerTurn start with 0 (-1 when game hasnt started) playersNum start with 1 (0 when game hasnt started)
            playerTurn = 0;
       
        Debug.Log("playersnum " + playersNum);
        Debug.Log("playerTurn " + playerTurn);
    }

    public static void NextNowPlaying()
    {
        TransmitionSituation = 0;
        YourMoneyScript.ChangeYourMoneyText(listOfPlayers[playerthatNowPlaying].GetComponent<PlayerAccount>().playerMoney);
        playerthatNowPlaying = playerTurn;
                   

    }

    public static int GetCurrentTileOfplayerthatNowPlaying()
    {
        return listOfPlayers[playerthatNowPlaying].GetComponent<Player_Movement>().playerTargetTile;
    }

    //return 0= dont do nothing, 1= player dont need to pay owner (asset is Available) - show him asset details, 2=player need to pay owner, 3= player is on Mail tail
    public static int TransmitionAction() 
    {
        if (AllAssets_Tiles.getTilesList()[PlayersList.GetCurrentTileOfplayerthatNowPlaying()].tileGroup== "ראוד")
        {
            
            return 3;
        }
        int owner = AllAssets_Tiles.getTilesList()[GetCurrentTileOfplayerthatNowPlaying()].owner;
        if (owner == -1)  //asset own someone
            return 1; //player dont need to pay owner (asset is Available) 
        if (owner != playerthatNowPlaying)  //asset isnt own me
        {

            int payment = AllAssets_Tiles.getTilesList()[GetCurrentTileOfplayerthatNowPlaying()].tiletransmitionPayment;
            listOfPlayers[playerthatNowPlaying].GetComponent<PlayerAccount>().playerMoney -= payment;
            listOfPlayers[owner].GetComponent<PlayerAccount>().playerMoney += payment;
            return 2;

        }
        return 0;

    }



    public void StartTheGame()
    {
        Debug.Log("StartTheGame()");
        CurrentplayerSituation = 0;
       playerTurn=0;
        playerthatNowPlaying = 0;
        playersNum = listOfPlayers.Count;


    }


}
