using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintDirectionalController : MonoBehaviour
{
    [SerializeField] float backAngle = 65f;
    [SerializeField] float sideAngle = 155f;
    [SerializeField] Transform MainTransform;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer spriteRenderer;

    private void LateUpdate()
    {
        Vector3 camForwardVector = new Vector3(Camera.main.transform.forward.x, 0f, Camera.main.transform.forward.z);
        Debug.DrawRay(Camera.main.transform.position, camForwardVector * 5f, Color.magenta);

        float signedAngle = Vector3.SignedAngle(MainTransform.forward, camForwardVector, Vector3.up);

        Vector2 animationDirection = new Vector2(0f, -1f);

        float angle = Mathf.Abs(signedAngle);


        // this changes the side animation based on what side
        
        if (signedAngle < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }

        if (angle < backAngle)
        {
            // Back animation
            animationDirection = new Vector2(0f, -1f);
        }
        else if (angle < sideAngle)
        {
            // side animtion, in this case, this is the right animation
            animationDirection = new Vector2(1f, 0f);
        }
        else
        {
            // front animation
            animationDirection = new Vector2(0f, 1f);
        }

        animator.SetFloat("moveX", animationDirection.x);
        animator.SetFloat("moveY", animationDirection.y);

    }
}
