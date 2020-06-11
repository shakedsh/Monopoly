using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static float tileSize = 350;
    public static bool playerNeedToMove = false;
    public static float steps = -1;

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.forward * Time.deltaTime;
        if(playerNeedToMove)
        {
            if(steps > 0)
            {
                transform.position += transform.forward * Time.deltaTime;
                steps--;
            }
            else
            {
                playerNeedToMove = false;
            }

        }
    }


    //lo beshimush
    public void MovePlayer()
    {
        transform.position += transform.forward * Time.deltaTime;
    }

}
