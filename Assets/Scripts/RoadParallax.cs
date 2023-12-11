using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadParallax : MonoBehaviour
{
    // Campo privado pero visible desde el inspector para configurar la velocidad el movimiento
    [SerializeField]
    float velocidadParallax = 0f;
    // Update se llama una vez por cada frame
    void Update()
    {
        // Obtenemos la velocidad del personaje
            gameObject.GetComponent<MeshRenderer>().material.mainTextureOffset += Vector2.right * velocidadParallax * Time.deltaTime;

    }
}