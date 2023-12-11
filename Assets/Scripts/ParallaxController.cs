using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    // Campo privado pero visible desde el inspector para configurar la velocidad el movimiento
    [SerializeField]
    float velocidadParallax = 0f;
    // Update se llama una vez por cada frame
    void Update()
    {
        gameObject.GetComponent<SpriteRenderer>().material.mainTextureOffset += Vector2.right * velocidadParallax * Time.deltaTime;

    }
}
