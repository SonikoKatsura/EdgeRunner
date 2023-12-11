using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float speed;
    

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(18, Random.Range(-0.8f, 2.2f), -1);
    }

    // Update is called once per frame
    void Update()
    {
        
            gameObject.GetComponent<Rigidbody>().velocity = Vector2.left * speed;
        
       
    }
    private void SpawnEnemy()
    {
        Instantiate(gameObject);
        gameObject.transform.position = new Vector3(18, Random.Range(-1f, 2.2f), -1);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            GameManager.gm.Invoke("AddPoint",0);
            SpawnEnemy();
            Destroy(gameObject);
        }
    }
}