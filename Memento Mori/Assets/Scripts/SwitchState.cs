using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchState : MonoBehaviour
{
    public GameObject someObject;
    public Sprite[] sprites;

    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        someObject.tag = "DadReading";
        spriteRenderer = someObject.GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = sprites[0];
        Invoke(nameof(SwitchSprite), 1.0f);
    }

    void SwitchSprite()
    {
        float randomTime = Random.Range(0.5f, 4.0f);
        if (someObject.CompareTag("DadReading"))
        {
            spriteRenderer.sprite = sprites[1];
            someObject.tag = "DadLookingUp";
        }

        else
        {
            spriteRenderer.sprite = sprites[0];
            someObject.tag = "DadReading";
        }

        Invoke(nameof(SwitchSprite), randomTime);
    }
}
