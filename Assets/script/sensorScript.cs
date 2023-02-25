using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensorScript : MonoBehaviour
{
    public electronControl controler;
    public static sensorScript instance;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {

        //Debug.Log("a");
        if (this.gameObject.name == "sensor up")
        {
            controler.up = 1;
        }
        if (this.gameObject.name == "sensor down")
        {
            controler.down = 1;
        }
        if (this.gameObject.name == "sensor right")
        {
            controler.right = 1;
        }
        if (this.gameObject.name == "sensor left")
        {
            controler.left = 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("b");
        if (this.gameObject.name == "sensor up")
        {
            controler.up = 0;
        }
        if (this.gameObject.name == "sensor down")
        {
            controler.down = 0;
        }
        if (this.gameObject.name == "sensor right")
        {
            controler.right = 0;
        }
        if (this.gameObject.name == "sensor left")
        {
            controler.left = 0;
        }
    }



}
