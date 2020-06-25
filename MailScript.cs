using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MailScript : MonoBehaviour
{
    public static List<Asset_tile> listOfLetters = new List<Asset_tile>();
    public GameObject mailPanel;
    public Boolean playeronMailWasTreated = false;
    public static String payOrGet;

    // Start is called before the first frame update
    void Start()
    {
        

        string trainLetter = "הנתמ תבכר סיטרכ";

        Asset_tile asTrain = new Asset_tile(trainLetter, "לארשי תבכר", 0, 0, 0);
        listOfLetters.Add(asTrain);
        listOfLetters.Add(asTrain);
        listOfLetters.Add(asTrain);
        listOfLetters.Add(asTrain);



        
        //start
        string tempText = "םיכנ תיינחב תינח";
        Asset_tile asTemp = new Asset_tile(tempText, "בוח", 600, 0, 0);
        listOfLetters.Add(asTemp);
        tempText = "בכר תרגא";
        asTemp = new Asset_tile(tempText, "בוח", 300, 0, 0);
        listOfLetters.Add(asTemp);

        tempText = "סמ רזחה";
        asTemp = new Asset_tile(tempText, "קנעמ", 100, 0, 0);
        listOfLetters.Add(asTemp);


    }

    public void PlayerOnMail()
    {

        mailPanel.gameObject.SetActive(true);
        int r = UnityEngine.Random.Range(0, listOfLetters.Count);
        LetterActions(listOfLetters[r]);
        this.gameObject.transform.FindChild("MailPanel").FindChild("TxtGroupLetters").GetComponent<Text>().text = listOfLetters[r].tileGroup;
        this.gameObject.transform.FindChild("MailPanel").FindChild("TxtLetter").GetComponent<Text>().text = listOfLetters[r].tileName;
        string payMonSH = " חש "  + listOfLetters[r].tileBuyingPrice+ payOrGet;
        if (listOfLetters[r].tileGroup == "לארשי תבכר")
            payMonSH = "ךלש םיסכנב ךל הכחמ סיטרכה";
        this.gameObject.transform.FindChild("MailPanel").FindChild("TxtPayOrGet").GetComponent<Text>().text = payMonSH;

    }

    public static void LetterActions(Asset_tile let)
    {
        if (let.tileGroup== "לארשי תבכר")
        {
            PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].GetComponent<PlayerAccount>().playerAssets.Add(let);
        }
        else if (let.tileGroup=="קנעמ")
        {
            PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].GetComponent<PlayerAccount>().playerMoney += let.tileBuyingPrice;
            payOrGet =  " :לבק";
        }
        else if (let.tileGroup == "בוח")
        {
            PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].GetComponent<PlayerAccount>().playerMoney -= let.tileBuyingPrice;
            payOrGet =  " :םלש";
        }
        //MailPanel

    }
    // Update is called once per frame
    void Update()
    {
        if ((PlayersList.TransmitionSituation == 3) && (playeronMailWasTreated == false))
        {
            PlayerOnMail();
            playeronMailWasTreated = true;
        }
        else if (PlayersList.TransmitionSituation != 3)
            playeronMailWasTreated = false;
    }
}
