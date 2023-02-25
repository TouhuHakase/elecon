using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformerUP : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject LowFields;
    public GameObject MidFields;
    public GameObject HighFields;
    public GameObject LowBlocks;
    public GameObject MidBlocks;
    public GameObject HighBlocks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "electron")
        {
            Debug.Log("UP");
            //Vector3 pos = other.gameObject.transform.position;
            other.gameObject.transform.position += new Vector3(0,0,-3);
            sensorScript.instance.controler.up = 0;
            sensorScript.instance.controler.down = 0;
            sensorScript.instance.controler.right = 0;
            sensorScript.instance.controler.left = 0;
            if (targetObject.transform.position.z == -3.8f)
            {
                LowFields.SetActive(false); LowBlocks.SetActive(false);
                MidFields.SetActive(true); MidBlocks.SetActive(true);
                HighFields.SetActive(false); HighBlocks.SetActive(false);
            }
            else if (targetObject .transform.position.z == -6.8f)
            {
                LowFields.SetActive(false); LowBlocks.SetActive(false);
                MidFields.SetActive(false); MidBlocks.SetActive(false);
                HighFields.SetActive(true); HighBlocks.SetActive(true);
            }
        }
    }
}
