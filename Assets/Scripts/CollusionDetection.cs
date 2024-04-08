using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollusionDetection : MonoBehaviour
{

    private Rigidbody rb;
    private MeshRenderer mr;
    private HingeJoint joint;
    [SerializeField] private GameObject particlePrefab;
    public Material Red, Gray;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        joint = rb.GetComponent<HingeJoint>();
        mr = rb.GetComponent<MeshRenderer>();
        

       
    }
    private void OnTriggerEnter(Collider other)
    {

        mr.material = Gray;
        rb.useGravity = true;
        rb.isKinematic = false;
        rb.constraints = RigidbodyConstraints.None;
        rb.constraints = RigidbodyConstraints.FreezePositionZ;


        var particle = Instantiate(particlePrefab, other.gameObject.transform.position, other.gameObject.transform.rotation);
            ParticleSystem ps = particle.GetComponent<ParticleSystem>();
            var main = ps.main;
        
    }
}
