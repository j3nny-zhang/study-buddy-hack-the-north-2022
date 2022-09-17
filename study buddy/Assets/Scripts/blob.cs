using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blob : MonoBehaviour
{
    public Sprite art;
    SpriteRenderer blob_renderer;

    // Start is called before the first frame update
    void Start()
    {
        blob_renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeSprite();
    }
    void ChangeSprite()
    {
        blob_renderer.sprite = art;
    }
}
