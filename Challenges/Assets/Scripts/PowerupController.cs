using System.Collections;
using UnityEngine;

public class PowerupController : MonoBehaviour
{
    [SerializeField] private GameObject firePoint;

    private void OnCollisionEnter2D(Collision2D col)
    {
        firePoint.SetActive(true);
        Destroy(gameObject);
    }
}