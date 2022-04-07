using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
    public GameObject bulletEffect;
    public GameObject bulletBloodEffect;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        transform.Rotate(0, 0, -90);
        Invoke("Death", 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //H�ndelser n�r bullet tr�ffar specifika colliders
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }

    private void Death()
    {
        Destroy(gameObject);
    }
}
