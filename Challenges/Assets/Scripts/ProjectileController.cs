using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float lifeTime;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        Invoke(nameof(DestroyProjectile), lifeTime);
    }
    
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
