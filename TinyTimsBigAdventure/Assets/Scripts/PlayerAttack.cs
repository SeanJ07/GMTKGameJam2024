using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    

    public Transform posAttack;
    public LayerMask enemyDef;
    public float rangeAttack;
    public int damage;
    public GameObject lightBeam;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
        lightBeam.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Attack();
            lightBeam.SetActive(true);
        }
        else
        {
            lightBeam.SetActive(false);

        }

    }

    public void Attack()
    {
        Collider2D[ ] hitEnemies = Physics2D.OverlapCircleAll(posAttack.position, rangeAttack, enemyDef);
        for(int i = 0; i < hitEnemies.Length; i++)
        {
            
            hitEnemies[i].GetComponent<EnemyController>().enemyHealth -= damage;
            
            Debug.Log("Enemy Health: " + hitEnemies[i].GetComponent<EnemyController>().enemyHealth);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(posAttack.position, rangeAttack);
    }
}
