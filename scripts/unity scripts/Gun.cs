using System.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{

    public float Damage = 10f;
    public float Range = 100f;
    public float inpactforce = 60f;
    public float fireRate = 15f;



    public Camera fpsCam;
    public ParticleSystem muzzleflash;
    public GameObject inpactEffect;
    public AudioSource gunshot;

    float nextTimeToFire = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            gunshot.Play();
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
        
    }

    void Shoot ()
    {
        muzzleflash.Play();
        RaycastHit hit;
       if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, Range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(Damage);
            }

            Target1 target1 = hit.transform.GetComponent<Target1>();
            if (target1 != null)
            {
                target1.TakeDamage(Damage);
            }

            if (hit.rigidbody !=null)
            {
                hit.rigidbody.AddForce(-hit.normal * inpactforce);
            }

            GameObject inpactGO = Instantiate(inpactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(inpactGO, 2f);
        }
    }

}
