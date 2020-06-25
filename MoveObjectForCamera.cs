using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectForCamera : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayersList.playerthatNowPlaying >= 0)
            this.transform.position = PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].transform.position;
    }
}
