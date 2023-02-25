using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class NewBehaviourScript : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    // Start is called before the first frame update
    [SerializeField]List<GameObject> blocks = new List<GameObject>();
    [SerializeField] List<GameObject> electron = new List<GameObject>();
    [SerializeField] List<float> M = new List<float>();
    [SerializeField] List<float> N= new List<float>();
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        //this.gameObject.transform.position += new Vector3(0, 0, -1.5f);
    }
    private void OnMouseDrag()
    {
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint);// - new Vector3(0,0,Camera.main.transform.position.z);
        transform.position = currentPosition;
        Transform NA = this.transform;
        Vector3 pos = NA.position;
        pos.z = -9.8f;
        NA.position = pos;
    }
    private void OnMouseUp()
    {
        //List<float> magnitude = new List<float>();
        if (blocks.Count == 0)
        {
            return;
            //èàóùÇ»Çµ
        }
        else
        {
            //Debug.Log("b");
            for (int p = 0; p < blocks.Count; p++)
            {
                M.Add((this.gameObject.transform.position - blocks[p].transform.position).magnitude);
            }

            for (int i = 0; i < electron.Count; i++)
            {
                N.Add((this.gameObject.transform.position - electron[i].transform.position).magnitude);
            }

            
            this.gameObject.transform.position = blocks[M.IndexOf(M.Min())].transform.position;
            Debug.Log(blocks[M.IndexOf(M.Min())].transform.position);

            if (this.gameObject.CompareTag("Low"))
            {
                this.gameObject.transform.position += new Vector3(0, 0, -1);
            }
            if (this.gameObject.CompareTag("Mid"))
            {
                this.gameObject.transform.position += new Vector3(0, 0, -4);
            }
            if (this.gameObject.CompareTag("High"))
            {
                this.gameObject.transform.position += new Vector3(0, 0, -7);
            }

            //Debug.Log("ÇŸÇ¢Ç∂Ç·Ç†ÅAÇ©Ç‘Ç¡ÇƒÇÈÇ©îªífÇ∑ÇÈÇ¡Ç∑ÇÊÅ`");
            //Debug.Log(blocks[M.IndexOf(M.Min())].transform.position.x);
            //Debug.Log(electron[N.IndexOf(N.Min())].transform.position.x);
            //Debug.Log(blocks[M.IndexOf(M.Min())].transform.position.y);
            //Debug.Log(electron[N.IndexOf(N.Min())].transform.position.y);

            if (blocks[M.IndexOf(M.Min())].transform.position.x == electron[N.IndexOf(N.Min())].transform.position.x && blocks[M.IndexOf(M.Min())].transform.position.y == electron[N.IndexOf(N.Min())].transform.position.y)
            {
                Debug.Log("ì«ÇﬁÇ¡Ç∑ÇÊÅ`");
                //Debug.Log(blocks[M.IndexOf(M.Min())].transform.position.x);
                //Debug.Log(electron[N.IndexOf(N.Min())].transform.position.x);
                //Debug.Log(blocks[M.IndexOf(M.Min())].transform.position.y);
                //Debug.Log(electron[N.IndexOf(N.Min())].transform.position.y);
                this.gameObject.transform.position = new Vector3(-15.86f, 3.34f, -9.8f);
                Debug.Log("åƒÇŒÇÍÇƒÇÈÇ¡Ç∑ÇÊÅ`");
            }

            else if (electron.Count == 0)
            {
                //return;
            }

            else
            {
                //return;
                //Debug.Log(blocks[M.IndexOf(M.Min())].transform.position.x);
                //Debug.Log(electron[N.IndexOf(N.Min())].transform.position.x);
                //Debug.Log(blocks[M.IndexOf(M.Min())].transform.position.y);
                //Debug.Log(electron[N.IndexOf(N.Min())].transform.position.y);
                //this.gameObject.transform.position = new Vector3(-15.86f, 3.34f, -9.8f);
                //Debug.Log("test");
            }


            M.Clear();
            N.Clear();
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(blocks + other.gameObject.name);
        //blocks.Add(other.gameObject);
        if (other.tag != "fields")
        {
            electron.Add(other.gameObject);
        }
        else
        {
            blocks.Add(other.gameObject);
        }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        //blocks.Remove(other.gameObject);
        if (other.tag != "fields")
        {
            electron.Remove(other.gameObject);
        }
        else
        {
            Debug.Log("remove");
            blocks.Remove(other.gameObject);
        }

    }

}
