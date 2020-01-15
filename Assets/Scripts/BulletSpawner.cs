using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1));
    }
}
