using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetTrigger("Movement");
        }
    }
}
