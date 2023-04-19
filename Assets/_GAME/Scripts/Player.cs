using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Selocanus
{
    public class Player : MonoBehaviour
    {
        public Camera ActiveCamera;
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
    }

}

