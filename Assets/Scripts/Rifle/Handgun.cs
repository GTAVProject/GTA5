using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handgun : MonoBehaviour
{
    [Header("Rifle Things")]
    public Camera cam;
    public float giveDamage = 10f;
    public float shootingRange = 100f;

    private void Update()
    {
        if (Input.GetbuttonDown("Fire1"))
        {
            Shoot();
        }
    }

  void Shoot()
    {
        RaycastHit hitInfo;

        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, shoottingRange))
        {
            Debug.Log(hitInfo.transform.name);
        }
    }
}