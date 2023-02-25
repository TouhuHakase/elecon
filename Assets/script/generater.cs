using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generater : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject score_object = null;
    public int B = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text score_text = score_object.GetComponent<Text>();
        score_text.text = "X" + B;
        
    }
    public GameObject prefab;
    public GameObject empty;
    public void OnClick()
    {
        for (int i = 0; i < 1; i++)
        {
            if (this.gameObject.CompareTag("Low"))
            {
                prefab = (GameObject)Instantiate(prefab, new Vector3(-11.6f, 3.3f, -9.8f), Quaternion.identity);
                prefab.transform.parent = empty.transform;
                B++;
            }
            if (this.gameObject.CompareTag("Mid"))
            {
                prefab = (GameObject)Instantiate(prefab, new Vector3(-11.6f, 1.9f, -9.8f), Quaternion.identity);
                prefab.transform.parent = empty.transform;
                B++;
            }
            if (this.gameObject.CompareTag("High"))
            {
                prefab = (GameObject)Instantiate(prefab, new Vector3(-11.6f, 0.6f, -9.8f), Quaternion.identity);
                prefab.transform.parent = empty.transform;
                B++;
            }
        }
    }
}
