using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class electronControl : MonoBehaviour
{
    public GameObject gameclea;
    public GameObject PushAnyKey;
    

    public int up = 0;
    public int down = 0;
    public int right = 0;
    public int left = 0;
    public GameObject LowFields;
    public GameObject MidFields;
    public GameObject HighFields;
    public GameObject LowBlocks;
    public GameObject MidBlocks;
    public GameObject HighBlocks;
    // Start is called before the first frame update
    void Start()
    {
        LowFields.SetActive(true); 
        
        LowBlocks.SetActive(true);
        
        MidFields.SetActive(false); 
        
        MidBlocks.SetActive(false);
        
        HighFields.SetActive(false); 
        
        HighBlocks.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (right == 1) {
            if (Input.GetKeyDown(KeyCode.D))
            {
                this.transform.Translate(1, 0, 0);
            }
        }
        if (down == 1) {
            if (Input.GetKeyDown(KeyCode.S))
            {
                this.transform.Translate(0, -1, 0);
                
            }
        }
        if (up == 1) {
            if (Input.GetKeyDown(KeyCode.W))
            {
                this.transform.Translate(0, 1, 0);
                
            }
        }
        if (left == 1) {
            if (Input.GetKeyDown(KeyCode.A))
            {
                this.transform.Translate(-1, 0, 0);
                
            }
        }
    }
    /*private void OnTriggerStay(Collider other)
    {
        //Debug.Log("test");
        if (other.gameObject.name == "Cube")
        {
            Debug.Log("クリア");
        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            Debug.Log("クリア");
            gameclea.GetComponent<Text>();
            gameclea.SetActive(true);
            PushAnyKey.GetComponent<Button>();
            PushAnyKey.SetActive(true);
        }
    }

    }
