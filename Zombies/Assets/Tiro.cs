using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour {
    Camera myCamera;
    int gunDamage;
    public Material[] gunMaterials = new Material[2];
    public int[] gunDamages = new int[2];
    public GameObject gun;

	// Use this for initialization
	void Start () {
        myCamera = GetComponentInChildren<Camera>();
        gunDamage = 20;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            ChangeGun(1);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            ChangeGun(2);
        }
    }

    void Shoot()
    {
        RaycastHit raycast;
        if (Physics.Raycast(myCamera.transform.position, myCamera.transform.forward, out raycast))
        {
            enemy e = raycast.transform.GetComponent<enemy>();

            if (e != null)
                e.Hit(gunDamage);
        }
    }
    void ChangeGun(int gunNumber)
    {
        gunDamage = gunDamages[gunNumber-1];
        gun.GetComponent<Renderer>().material = gunMaterials[gunNumber - 1];
    }

    private void OnParticleCollision(GameObject other)
    {
        
    }
}
