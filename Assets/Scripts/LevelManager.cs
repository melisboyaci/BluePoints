using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance { get; private set; }

    public Camera Camera;
    public GameObject panel;
    public GameObject ParticlePrefab;
    public GameObject Text;
    public TextMeshProUGUI Level;
    public static int levelCount = 1;
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }

    }


    private void Start()
    {
       
        panel.SetActive(false);
    }
    private void Update()
    {
        Level.text = "Level: " + levelCount;
        int counter;

        if (Input.GetMouseButtonDown(0))
        {
            Destroy(Text);
        }
        Collider[] colliders = Physics.OverlapSphere(transform.position, 100f);
        counter = colliders.Length;

        foreach (Collider collider in colliders)
        {
            Vector3 colliderPosition = collider.transform.position;

            Vector3 viewportPosition = Camera.WorldToViewportPoint(colliderPosition);

            if (viewportPosition.y < -5)
            {
                counter--;
            }
        }
        if (counter == 0 && colliders != null) {
           
            EndLevel();
        }


        
    }


    public void EndLevel()
    {
        panel.SetActive(true);
        var particle = Instantiate(ParticlePrefab);
        ParticleSystem ps = particle.GetComponent<ParticleSystem>();
        var main = ps.main;
    }
}
