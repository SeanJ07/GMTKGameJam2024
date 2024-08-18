using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSizeChange : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isSmall;
    private float growBigCharge;
    void Start()
    {
        isSmall = true;
        growBigCharge = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && isSmall && growBigCharge > 0)
        {
            transform.localScale = new Vector3(2, 2, 2);
            isSmall = false;
            growBigCharge -= 1;
            

        }


        if(Input.GetKeyDown(KeyCode.S) && !isSmall)
        {
            transform.localScale = new Vector3(1, 1, 1);
            isSmall = true;
            
        }

         
    }
}
