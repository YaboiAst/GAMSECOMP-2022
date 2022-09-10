    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PlayerController : MonoBehaviour{

        public float speed = 10f;
        public Vector2 lastClickedPos;
        Vector2 lockPos;
        bool moving = false;

        private void Start() {
            lastClickedPos = transform.position;
        }

        private void FixedUpdate(){
            // MOVIMENTAÇÃO SEGUINDO O MOUSE
            if(Input.GetMouseButtonDown(0)){
                lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                moving = true;
            }

            if(moving && (Vector2)transform.position != lastClickedPos){
                transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, speed * Time.deltaTime);
            }
            else moving = false;
        }

        private void OnCollisionEnter2D(Collision2D other) {
            lockPos = transform.position;
            lastClickedPos = lockPos;
        }

        void OnCollisionStay2D(Collision2D other) {
            if(other.collider.bounds.Contains(transform.position + new Vector3(1,1,0))){
                lastClickedPos = lockPos;
            }
        }
    }
