using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBlob : MonoBehaviour
{

    public Transform blobPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(blobPos.transform.position.x * 50 + 400, 400, 0);
    }
}
