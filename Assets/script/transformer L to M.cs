using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformer : MonoBehaviour
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
            Debug.Log("mid");
            //Vector3 pos = other.gameObject.transform.position;
            other.gameObject.transform.position += new Vector3(0,0,-3);
            
        }
    }
}
