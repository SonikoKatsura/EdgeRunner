using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Velocidad del jugador
    [SerializeField] float playerJump = 0f;
    private Rigidbody rb;
    private bool canJump;
    


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        canJump = true;
    }
    // Update se llama una vez por cada frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && canJump)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(transform.up * playerJump, ForceMode.Impulse);
            canJump = false;
            gameObject.GetComponent<AudioSource>().enabled = true;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
            gameObject.GetComponent<AudioSource>().enabled = false;
        }
       
    }
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameManager.gm.Invoke("Death", 0);
            Destroy(this.gameObject);

        }
    }
}

