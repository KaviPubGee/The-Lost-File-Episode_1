using UnityEngine;

public class ElevatorInteraction : MonoBehaviour, IInteractable
{
    public Animator animator;
    public void Interact()
    {
        if (this.gameObject.CompareTag("Outside Button"))
        {
            animator.Play("Door_Open");
        }
        else if (this.gameObject.CompareTag("Inside Button"))
        {
            animator.Play("Door_Close");
        }
    }
}
