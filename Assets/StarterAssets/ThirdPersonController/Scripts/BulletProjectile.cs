using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    [SerializeField] private Transform vfxHitGreen;
    [SerializeField] private Transform vfxHitRed;

    private Rigidbody bulletRigidbody;

    public int damageAmount = 20;
    // Start is called before the first frame update
    private void Awake()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Start()
    {
        float speed = 10f;
        bulletRigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 10);
    }

    private void OnTriggerEnter(Collider other){
        if(other.GetComponent<BulletTarget>() != null){
            //Hit target
            Instantiate(vfxHitGreen, transform.position, Quaternion.identity);
        }
        else{
            //Hit something
            Instantiate(vfxHitRed, transform.position, Quaternion.identity);
        }
        //Destroy(gameObject);
        Destroy(transform.GetComponent<Rigidbody>());

        if(other.tag == "Dragon"){
            other.GetComponent<Dragon>().TakeDamage(damageAmount);
        }
    }
}
