using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blobAI : MonoBehaviour
{
    private float moveSpeed = 1.0f;

    private bool isWandering = false;
    private bool isMoving = false;

    private float offset = 5.0f;

    // Update is called once per frame
    private void Update()
    {

        if (isWandering == false)
        {
            StartCoroutine(wander());
            Debug.Log(Screen.width);
        }


        if (isMoving == true)
            transform.position += transform.right * moveSpeed * Time.deltaTime;

        if (isMoving == false)
            this.transform.localRotation = Quaternion.Euler(0, 180, 0);

        if (this.transform.position.x < 0 && isMoving == false)
            this.transform.localRotation = Quaternion.Euler(0, 0, 0);

        if (this.transform.position.x < -offset)
            this.transform.localRotation = Quaternion.Euler(0, 0, 0);

        if (this.transform.position.x > offset)
            this.transform.localRotation = Quaternion.Euler(0, 180, 0);

    }


    IEnumerator wander()
    {
        int moveTime = Random.Range(1, 4);
        int moveWait = Random.Range(0, 2);

        isWandering = true;
        yield return new WaitForSeconds(moveWait);
        isMoving = true;
        yield return new WaitForSeconds(moveTime);
        isMoving = false;
        yield return new WaitForSeconds(moveWait);
        isWandering = false;
    }
}
