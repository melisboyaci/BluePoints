using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetection : MonoBehaviour
{
    //This script is for blue points that have hinge joint.

    public Material Blue, Gray;
   
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo))
            {

                GameObject gameObject = hitInfo.transform.gameObject;
                if(gameObject.GetComponent<MeshRenderer>().material.color == Blue.color)
                {
                    gameObject.GetComponent<MeshRenderer>().material = Gray;
                    
                    gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                    gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;


                    gameObject.GetComponent<Rigidbody>().useGravity = true;
                    gameObject.GetComponent<Rigidbody>().isKinematic = false;
                }
               


            }

        }
    }
}
