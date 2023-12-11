using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Campo privado pero visible desde el inspector para obtener la posición del jugador
    [SerializeField] GameObject player;
    [SerializeField] Camera[] cameras;
    [SerializeField] int activecamera;
    // Update is called once per frame
    private void Start()
    {
        ChangeCamera(activecamera);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (activecamera == cameras.Length - 1) activecamera = 0;
            else activecamera++;
            ChangeCamera(activecamera);
        }
        // Guardamos la posición del jugador
        if (!player.IsDestroyed())
        { 
        Vector2 playerPosition = player.transform.position;
        // Aplicamos la posición del jugador a la posición de la cámara manteniendo 'x' e 'y' sin cambios
        gameObject.transform.SetPositionAndRotation(new Vector3(playerPosition.x + 2, transform.position.y, transform.position.z),
        Quaternion.identity);
        }

      
    }
    void ChangeCamera( int camera)
    { 
        if (cameras.Length >=1) 
        {
            for (int i = 0; i < cameras.Length; i++)
            {
                if (camera == i) cameras[i].enabled = true;
                else cameras[i].enabled = false;
            }
        }
    }
}
