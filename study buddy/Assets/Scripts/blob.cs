using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blob : MonoBehaviour
{
    public List<Sprite> blobs;
    SpriteRenderer blob_renderer;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        blob_renderer = gameObject.GetComponent<SpriteRenderer>();
        index = Random.Range(0, 6);
        ChangeSprite();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ChangeSprite()
    {
        blob_renderer.sprite = blobs[index];
    }
}
