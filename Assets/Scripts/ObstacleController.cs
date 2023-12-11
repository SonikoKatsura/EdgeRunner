using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(10.23f, -2.574f, -1.022f);
    }

    // Update is called once per frame
    void Update()
    {
        
            gameObject.GetComponent<Rigidbody>().velocity = Vector2.left * speed;
 
        
    }
    private void SpawnObstacle()
    {
        Instantiate(gameObject);
        gameObject.transform.position = new Vector3(10.23f, -2.574f, -1.022f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            GameManager.gm.Invoke("AddPoint", 0);
            SpawnObstacle();
            Destroy(gameObject);
        }
    }
}
