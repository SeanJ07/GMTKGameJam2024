using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerSizeChange : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isSmall;
    private float growBigCharge;
    public GameObject flashlight;
    public TextMeshProUGUI growthText;
    void Start()
    {
        isSmall = true;
        growBigCharge = 3;
        flashlight.SetActive(false);
        growthText.text = "Growth Charges: " + growBigCharge;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && isSmall && growBigCharge >= 0)
        {
            transform.localScale = new Vector3(2, 2, 2);
            isSmall = false;
            growthText.text = "Growth Charges: " + growBigCharge;
            growBigCharge -= 1;
            flashlight.SetActive(true);

        }


        if(Input.GetKeyDown(KeyCode.S) && !isSmall)
        {
            transform.localScale = new Vector3(1, 1, 1);
            isSmall = true;
            flashlight.SetActive(false);
        }

         
    }

}
