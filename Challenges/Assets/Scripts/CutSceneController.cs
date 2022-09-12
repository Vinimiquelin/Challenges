using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneController : MonoBehaviour
{
    public static bool isCutSceneOn;
    public Animator camAnim;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            Debug.Log("Starting cutscene!");
            isCutSceneOn = true;
            camAnim.SetBool("cutscene1", true);
            Invoke(nameof(StopCutScene), 3f);
        }
    }

    void StopCutScene()
    {
        isCutSceneOn = false;
        camAnim.SetBool("cutscene1", false);
        Destroy(gameObject);
    }
}
