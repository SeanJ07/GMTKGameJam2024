using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    public float speed = 1f;

    public float enemyHealth;

    SpriteRenderer spr;

    // Start is called before the first frame update
    void Start()
    { 
        spr = gameObject.GetComponent<SpriteRenderer>();
        enemyHealth = 10;
    }

    // Update is called once per frame
    void Update()
    {
        EnemyDeath();
    }
    private void FixedUpdate()
    {
        Vector3 target = GameObject.Find("Player").transform.position;
        //transform.Translate(Vector2.left * Time.deltaTime * speed);
        if (this.transform.position.x - target.x < 2)
        {
            this.transform.Translate(Vector2.right * Time.deltaTime * speed);
            spr.flipX = true;
        }
        else if (this.transform.position.x - target.x > 2)
        {
            this.transform.Translate(Vector2.left * Time.deltaTime * speed);
            spr.flipX = false;
        }

    }
    private void EnemyDeath()
    {
        if(enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
