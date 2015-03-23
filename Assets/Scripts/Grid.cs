using UnityEngine;using System.Collections;

public class Grid : MonoBehaviour
{
    Color Origin;
    void Start()
    {
        Origin = transform.GetComponent<SpriteRenderer>().color;
    }
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), transform.position.z);

      /*  if (Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Circle").transform.position) < 10)        {            transform.GetComponent<SpriteRenderer>().color = GameObject.FindGameObjectWithTag("Circle").transform.GetComponent<SpriteRenderer>().color;
            print(GameObject.FindGameObjectWithTag("Circle").name);        }*/
        if (Vector3.Distance(transform.position, GameObject.Find("Circle2").transform.position) < 10)
        {
            transform.GetComponent<SpriteRenderer>().color = GameObject.Find("Circle2").transform.GetComponent<SpriteRenderer>().color;
        }
        else if (Vector3.Distance(transform.position, GameObject.Find("Circle3").transform.position) < 10)
        {
            transform.GetComponent<SpriteRenderer>().color = GameObject.Find("Circle3").transform.GetComponent<SpriteRenderer>().color;
        }
        else if (Vector3.Distance(transform.position, GameObject.Find("Circle4").transform.position) < 10)
        {
            transform.GetComponent<SpriteRenderer>().color = GameObject.Find("Circle4").transform.GetComponent<SpriteRenderer>().color;
        }
        else if (Vector3.Distance(transform.position, GameObject.Find("Circle5").transform.position) < 10)
        {
            transform.GetComponent<SpriteRenderer>().color = GameObject.Find("Circle5").transform.GetComponent<SpriteRenderer>().color;
        }
        else
        {
            transform.GetComponent<SpriteRenderer>().color = Origin;
        }
    }
}