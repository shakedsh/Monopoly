using UnityEngine;

public class Cube : MonoBehaviour
{
    private bool isCubeMoving = true;
    int diceCount;
    public static int diceResult=0;
    

    void Update()
    {
       diceCount = 0;
        if (isCubeMoving && GetComponent<Rigidbody>().velocity.magnitude <= 0.1)
        {
            Debug.Log("stop"); // הקוביה הפסיקה לזוז
            isCubeMoving = false;
            diceResult=WhichSideUp();
            Movement.playerNeedToMove = true;
            Movement.steps = diceResult * Movement.tileSize;
            
        }
    }

    // בדיקה אחרי שהקוביה נחתה, מה הצד העליון
    int WhichSideUp()
    {
        if (Vector3.Dot(-transform.up, Vector3.up) > 0.6f)
            diceCount = 1;
        if (Vector3.Dot(transform.forward, Vector3.up) > 0.6f)
            diceCount = 2;
        if (Vector3.Dot(transform.up, Vector3.up) > 0.6f)
            diceCount = 3;
        if (Vector3.Dot(-transform.forward, Vector3.up) > 0.6f)
            diceCount = 4;
        if (Vector3.Dot(transform.right, Vector3.up) > 0.6f)
            diceCount = 5;
        if (Vector3.Dot(-transform.right, Vector3.up) > 0.6f)
            diceCount = 6;
        Debug.Log("up = " + diceCount);

        return diceCount;
    }

    /*
    // בדיקה האם הקוביה הגיעה לקרקע, הבדיקה לא טובה כי יתכן שהיא תתגלגל על הקרקע
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == 8)
            Debug.Log("karka");
    }
    */

    
    
       



}
