using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using System.Linq;

public class PlayerAssetListBTNScript : MonoBehaviour
{
    public Transform playersOrigin;

    public TMP_InputField name;
    public GameObject playerPrefab;
    GameObject player;

    private void Update()
    {
        PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].GetComponent<PlayerAccount>().playerAssets.OrderBy(x => x.tileGroup);
        for (int i = 0; i < Math.Min(PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].GetComponent<PlayerAccount>().playerAssets.Count, this.gameObject.transform.childCount); i++)
        {
            string tempName = PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].GetComponent<PlayerAccount>().playerAssets[i].tileName;
            string tempGroup = PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].GetComponent<PlayerAccount>().playerAssets[i].tileGroup;
            string tempBUY= ":היינק ריחמ " + "\n" + PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].GetComponent<PlayerAccount>().playerAssets[i].tileHouseBuyingPrice;
            string tempTRANS = ":סכנב רוקיב לע םולשת " + "\n" + PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].GetComponent<PlayerAccount>().playerAssets[i].tiletransmitionPayment;
            this.gameObject.transform.GetChild(i).gameObject.SetActive(true);
           // this.gameObject.transform.GetChild(i).GetComponent<Image>().color = Color.red;
            this.gameObject.transform.GetChild(i).GetComponentInChildren<Text>().text = tempName + "\n" + tempGroup + "\n" + tempBUY+ "\n" + tempTRANS;
        }

    }
    private void Start()
    {
        
    }

    // Start is called before the first frame update
    public void CreateBTN()
    {
       // player = Instantiate(playerPrefab, PlayerAssetListBTN);
        //player.GetComponent<Renderer>().material.SetColor("_Color", randomColor);
    }

}
