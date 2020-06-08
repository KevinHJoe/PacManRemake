using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WarpLeft : MonoBehaviour
{

    public Transform Destination;       // Gameobject where they will be teleported to


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" )
        {
            //pMC.transform.Translate(right);
            col.transform.position = Destination.transform.position;
            col.transform.rotation = Destination.transform.rotation;
        }
        if(col.gameObject.tag == "Enemy")
        {
            
            col.transform.position = Destination.transform.position;
            col.transform.rotation = Destination.transform.rotation;
        }
    }
}
