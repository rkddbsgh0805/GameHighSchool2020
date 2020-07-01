using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidbody = /*gameObject*/ GetComponent<Rigidbody>();

        float xAxia = Input.GetAxia("Horigontal");
        float yAxia = Input.GetAxia("Vertical");

        rigidbody.AddForce(new Vector3(xAxia, 0, yAxia) * m_Speed);

        if (Input.GetKeyup(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(Vector3.left * 100f);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
           rigidbody.AddForce(Vector3.forward * 100f);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
             rigidbody.AddForce(Vector3.forward * 100f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(Vector3.right* 100f);
        }
 
        if(Input.GetKeyUp(KeyCode.Space))
            Die();
    }

    public void Die()
    {
        Debug.Log("사망");
        gameObject.SetActive(false);
    }
}