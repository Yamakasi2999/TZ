using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimator : MonoBehaviour
{
    NavMeshAgent agent;
    public Animator anim;
    [SerializeField] Abilities abbs;

    float MotionSmoothTime = .1f;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = agent.velocity.magnitude / agent.speed;
        anim.SetFloat("speed", speed, MotionSmoothTime, Time.deltaTime);
        if (Input.GetKey(abbs.ability1) && abbs.isCooldown == false)
        {
            print("Анимация");
            anim.SetTrigger("spells");
        }
        else if (Input.GetKey(abbs.ability2) && abbs.isCooldown2 == false)
        {
            anim.SetTrigger("spells");
            print("Анимация");
        }
        else if (Input.GetKey(abbs.ability3) && abbs.isCooldown3 == false)
        {
            anim.SetTrigger("spells");
            print("Анимация");
        }
    }
}
