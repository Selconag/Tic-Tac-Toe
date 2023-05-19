using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Selocanus
{
    public class Player : MonoBehaviour
    {
        public Camera ActiveCamera;
        private CharacterController controller;
        private Vector3 playerVelocity;
        private bool groundedPlayer;
        private float playerSpeed = 2.0f;
        private float jumpHeight = 1.0f;
        private float gravityValue = -9.81f;

        private void Start()
        {
            controller = gameObject.AddComponent<CharacterController>();
        }

        void Update()
        {
            //groundedPlayer = controller.isGrounded;
            if (groundedPlayer && playerVelocity.y < 0)
            {
                playerVelocity.y = 0f;
            }

            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            controller.Move(move * Time.deltaTime * playerSpeed);

            if (move != Vector3.zero)
            {
                gameObject.transform.forward = move;
            }

            // Changes the height position of the player..
            if (Input.GetButtonDown("Jump") && groundedPlayer)
            {
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            }

            playerVelocity.y += gravityValue * Time.deltaTime;
            controller.Move(playerVelocity * Time.deltaTime);
        }


    }


    #region Android
    /*
     
        void Update()
        {
            //Check if player is touching?
            if (Input.touchCount > 0 || Input.GetMouseButton(0))
            {
                //Touch touch = Input.GetTouch(0);
                Vector2 mouseToScreen = Input.mousePosition;
                //if (touch.phase == TouchPhase.Began)
                //{
                //    RaycastHit hit;
                //    Ray ray = ActiveCamera.ScreenPointToRay(Input.GetTouch(0).position);
                //    //Debug.Log("This clicks position is:" + hitPos);
                //    if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                //    {
                //        if (hit.transform.tag == "Slot") Debug.Log("Sex");
                //    }
                //}
                if (Input.GetMouseButtonDown(0))
                {
                    RaycastHit hit;
                    Ray ray = ActiveCamera.ScreenPointToRay(mouseToScreen);
                    //Debug.Log("This clicks position is:" + hitPos);
                    if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                    {
                        if (hit.transform.tag == "Slot") Debug.Log("Sex");
                    }
                }

            }

                
            
        }
     */
    #endregion

}

