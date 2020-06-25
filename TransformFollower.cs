using UnityEngine;
using System.Collections;

public class TransformFollower : MonoBehaviour
{
    public static Vector3 camLOCValue=new Vector3();

    [SerializeField]
    private Transform target;

    [SerializeField]
    private Vector3 offsetPosition;

    [SerializeField]
    private Space offsetPositionSpace = Space.Self;

    [SerializeField]
    private bool lookAt = true;
    private void Start()
    {
        camLOCValue = transform.position;
    }
    private void Update()
    {
        if(PlayersList.CurrentplayerSituation>=1)
        {
            this.transform.position = PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].GetComponent<Player_Movement>().camPOSForPlayer;
           
                //transform.Rotate(this.transform.rotation.x + 25.873f, this.transform.rotation.y + camROTValue - 10.275f, this.transform.rotation.z - 25.896f); 
                transform.rotation = Quaternion.Euler(PlayersList.listOfPlayers[PlayersList.playerthatNowPlaying].GetComponent<Player_Movement>().camROTForPlayer);


            
            //Debug.Log("    this.transform.position.x  " + this.transform.position.x);

        }
        //Refresh();
    }

    /*
    public void Refresh()
    {
        if (target == null)
        {
            Debug.LogWarning("Missing target ref !", this);

            return;
        }

        // compute position
        if (offsetPositionSpace == Space.Self)
        {
            transform.position = target.TransformPoint(offsetPosition);
        }
        else
        {
            transform.position = target.position + offsetPosition;
        }
        /*
        // compute rotation
        if (lookAt)
        {
            transform.LookAt(target);
        }
        else
        {
            transform.rotation = target.rotation;
        }
        
    }
    */
}