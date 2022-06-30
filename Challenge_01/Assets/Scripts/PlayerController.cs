 using UnityEngine;

 public class PlayerController : MonoBehaviour {
         [SerializeField] public float jumpVelocity = 5.0f;
         [SerializeField] public float flyVelocity = 12.0f;
         [SerializeField] public float moveVelocity = 3.0f;
         [SerializeField] private Rigidbody2D rigidbody2d;
         [SerializeField] private SpriteRenderer spriteRenderer;
         
         void Start() {
            rigidbody2d.freezeRotation = true;   
         }
         void Update(){
            Jump();
            Fly();
            Move();
         }

         void Jump(){
             if(Input.GetKeyDown(KeyCode.Space)){
     
                rigidbody2d.velocity = Vector2.up * jumpVelocity;
             }
         }

         void Fly() {
             if(Input.GetKeyDown(KeyCode.Z)){
     
                 rigidbody2d.velocity = Vector2.up * flyVelocity;
             }
         }

         void Move(){
             if(Input.GetKeyDown(KeyCode.LeftArrow)){
                spriteRenderer.flipX = true;
                rigidbody2d.velocity = Vector2.left * moveVelocity;
             }

            if(Input.GetKeyDown(KeyCode.RightArrow)){
                spriteRenderer.flipX = false;
                rigidbody2d.velocity = Vector2.right * moveVelocity;
             }
         }
     }
