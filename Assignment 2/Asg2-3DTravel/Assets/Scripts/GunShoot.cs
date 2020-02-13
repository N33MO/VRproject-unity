using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public GameObject projectile;
    public AudioClip shootSound;

    private float bulletSpeed = 50f;
    private AudioSource source;
    private float volLoRange = 0.5f;
    private float volHiRange = 1.0f;

    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            float vol = Random.Range(volLoRange, volHiRange);
            source.PlayOneShot(shootSound, vol);
            GameObject throwThis = Instantiate (projectile, transform.position, transform.rotation) as GameObject;
            throwThis.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, bulletSpeed));
        }

    }
}
