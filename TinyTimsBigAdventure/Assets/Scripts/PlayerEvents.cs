using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
        {
            // Gameover
            SceneManager.LoadScene(3);
        }
        else if (collision.tag == "medallion")
        {
            // Endscreen
            SceneManager.LoadScene(2);
        }
    }
}
