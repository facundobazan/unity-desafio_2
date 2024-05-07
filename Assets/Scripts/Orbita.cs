using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nube_Voladora : MonoBehaviour
{
    public Transform eje;
    public Transform nube;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nube.RotateAround(eje.position, Vector3.up, speed * Time.deltaTime);
    }
}
