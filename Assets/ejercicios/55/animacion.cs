using UnityEngine;
using UnityEngine.InputSystem;

public class animacion : MonoBehaviour
{
    Animator animator;
    bool pegando;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pegando = !pegando;
            animator.SetBool("golpeando", pegando);
        }
    }
}
