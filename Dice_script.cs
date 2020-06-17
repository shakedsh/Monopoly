using System;
using System.Collections;
using UnityEngine;

public class Dice_script : MonoBehaviour
{
    private int diceCount;
    public static int diceResult = 0;
    private Vector3 offset;
    private Vector3 screenPoint;
    private bool isCubeMoved = true; // haim hezizu et hakubiya im haahbar- lasim lev sheMeuthal be true
    private bool isStopCheck = false; // haim hayta atzira rishona veYesh hamtana lebdika shniya

    public float diceRotateSpeed = 1f; // מהירות סיבוב הקובה בגרירתה
    public float diceMinHeight = 0f; // גובה מינימלי של הקוביה
    public float diceMaxHeight = 13f; // גובה מקסימלי של הקוביה
    public float dicePositionZ = -4f; // מיקום הקוביה ביו הבתים לשם העיר
    private Vector3 old_pos;
    private Vector3 stop1_pos;


    private void Start()
    {
        old_pos = transform.position;
    }

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(screenPoint.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        isCubeMoved = true;

        Vector3 curScreenPoint = new Vector3(screenPoint.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;

        transform.Rotate(transform.eulerAngles.x + diceRotateSpeed, transform.eulerAngles.y + diceRotateSpeed, transform.eulerAngles.z + diceRotateSpeed);
    }

    void Update()
    {
        if (isCubeMoved)
        {

            if (isStopCheck==false&&(Vector3.Distance(transform.position, old_pos) < 0.1f)&&(transform.position.y<1f)&&(transform.rotation.x<0.1f|| transform.rotation.y <  0.1f || transform.rotation.z < 0.1f))
            {
                stop1_pos = transform.position;
                Debug.Log("Stop!1");
                StartCoroutine("checkTransformMove");
                
            }
            old_pos = transform.position;
        }
           
            // הגבלת הנמיכות של הקוביה
            if (transform.position.y < diceMinHeight)
                transform.position = new Vector3(transform.position.x, diceMinHeight, transform.position.z);

            // הגבלת הגובה שניתן להרים את הקוביה
            if (transform.position.y > diceMaxHeight)
                transform.position = new Vector3(transform.position.x, diceMaxHeight, transform.position.z);

            // במקום המתאים z החזרת הקוביה לציר
            transform.position = new Vector3(transform.position.x, transform.position.y, dicePositionZ);
        }

        IEnumerator checkTransformMove()
        {
        isStopCheck = true;
            Debug.Log("checkTransformMove");
            yield return new WaitForSeconds(1f);
        if ((Vector3.Distance(transform.position, stop1_pos) < 0.1f) && (transform.position.y < 1f) && (transform.rotation.x < 0.1f || transform.rotation.y < 0.1f || transform.rotation.z < 0.1f))
            {
                Debug.Log("Stop!2");
                isCubeMoved = false;
   
                    diceResult = WhichSideUp();
                    //Movement.playerNeedToMove = true;
                    Player_Movement.playerSituation = 1;
            }
        else
            stop1_pos = transform.position;
        isStopCheck = false;
        old_pos = transform.position;
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
    
}
