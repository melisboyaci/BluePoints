using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PointManager : MonoBehaviour
{

    public LineRenderer lineRenderer;
    public GameObject Sphere1, Sphere2;



    void Start()
    {
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, Sphere1.transform.position);
        lineRenderer.SetPosition(1, Sphere2.transform.position);


    }

    void Update()
    {
        Transform sphere1 = Sphere1.transform;
        Transform sphere2 = Sphere2.transform;
        lineRenderer.SetPosition(0, Sphere1.transform.position);
        lineRenderer.SetPosition(1, Sphere2.transform.position);
        

        

    }

    
}
