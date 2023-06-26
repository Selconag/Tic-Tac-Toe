using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using SelocanusToolkit;

public class AnimatedDoor : MonoBehaviour
{
    public bool OpenBackward = false;
    private bool doorIsOpen = false;
    public float DoorOpeningTime = 1f;

    private void Update()
    {
        if (doorIsOpen) DoorToggleSequence();
    }

    public void DoorToggleSequence()
    {
        //Play door's sound
        AudioManager.Instance.PlayCreakyDoorSound();
        //Open door 90 degrees on the desired way
        bool direction = OpenBackward & doorIsOpen;
        transform.DOLocalRotate(new Vector3(0,direction.ToInt() * 90,0),DoorOpeningTime);
        doorIsOpen = false;
    }

}
