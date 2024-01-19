using System.Collections;
using UnityEngine;

public class AttackState : StateMachineBehaviour
{
    Transform player;
    public float attackDamage = 10f;
    private bool hasAttacked = false;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (!hasAttacked)
        {
            animator.transform.LookAt(player);
            float distance = Vector3.Distance(player.position, animator.transform.position);

            if (distance > 3.5f)
            {
                animator.SetBool("isAttacking", false);
            }
            else
            {
                PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
                if (playerHealth != null)
                {
                    playerHealth.TakeDamage(attackDamage);
                    hasAttacked = true;
                    // Acessa o componente MonoBehaviour e inicia a rotina
                    MonoBehaviour script = animator.GetComponent<MonoBehaviour>();
                    script.StartCoroutine(ResetAttackFlag());
                }
            }
        }
    }

    IEnumerator ResetAttackFlag()
    {
        yield return new WaitForSeconds(1.0f); // Ajuste para 1 segundo
        hasAttacked = false;
    }
}
