using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;  //DOTween‚ðŽg‚¤‚Æ‚«‚Í‚±‚Ìusing‚ð“ü‚ê‚é

public class NeedleScript : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject LowFields;
    public GameObject MidFields;
    public GameObject HighFields;
    public GameObject LowBlocks;
    public GameObject MidBlocks;
    public GameObject HighBlocks;
    RectTransform rectTransform;
     // Vector3 tmp; 
    // Start is called before the first frame update
    void Start()
    {
        // tmp = GameObject.Find("electron").transform.position;
        rectTransform = this.GetComponent<RectTransform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (targetObject.transform.position.z >= -0.9f)
        {
            //Debug.Log("low");
            rectTransform.DOLocalRotate(Vector3.forward * 65f, 2f);

        }
        else if (targetObject.transform.position.z <= -6.8f)
        {
            //Debug.Log("h");
            rectTransform.DOLocalRotate(Vector3.forward * -65f, 2f);
        }
        else
        {
            
                //Debug.Log("m");
                rectTransform.DOLocalRotate(Vector3.forward * 0f, 2f);

        }
    }

}
