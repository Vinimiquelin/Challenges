 using UnityEngine;
 using System.Collections;
     
     public class PlayerController : MonoBehaviour {

         [SerializeField] public float jumpVelocity = 5.0f;
         [SerializeField] public float walkVelocity = 3.0f;
         [SerializeField] private Rigidbody2D rigidbody2d;
         [SerializeField] private SpriteRenderer spriteRenderer;
         public Animator animator;
         
         void Start() 
         {
            rigidbody2d.freezeRotation = true;   
         }
         void Update()
         {
             if (!CutSceneController.isCutSceneOn)
             {
                 Jump();
                 Move();  
             }
         }

         void Jump(){
             if(Input.GetKeyDown(KeyCode.Space))
             {
                 rigidbody2d.velocity = Vector2.up * jumpVelocity;
             }
         }

         void Move(){
             if(Input.GetKeyDown(KeyCode.LeftArrow))
             {
                spriteRenderer.flipX = true;
                rigidbody2d.velocity = Vector2.left * walkVelocity;
                animator.SetBool("iswalking", true);
             }

            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                spriteRenderer.flipX = false;
                rigidbody2d.velocity = Vector2.right * walkVelocity;
                animator.SetBool("iswalking", true);
             }
         }
     }
