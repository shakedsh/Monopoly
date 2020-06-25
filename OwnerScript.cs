using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OwnerScript : MonoBehaviour
{
    public static int ownerValue = -1;
    Text owner;
    // Start is called before the first frame update
    void Start()
    {
        owner = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        owner.text = OwnerNumToName();
    }

    public string OwnerNumToName()
    {
        int ownerNum = -1;
        if (PlayersList.playerthatNowPlaying >= 0)
            ownerNum = AllAssets_Tiles.getTilesList()[PlayersList.GetCurrentTileOfplayerthatNowPlaying()].owner;
        if (ownerNum == -1)
            return "היינקל יונפ סכנה";
        return ":תולעבב סכנה" + "\n" + PlayersList.listOfPlayers[ownerNum].GetComponent<PlayerAccount>().playerName;
    }
}
