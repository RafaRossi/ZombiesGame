using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{

    NavMeshAgent agent;
    int vida;

    // Use this for initialization
    void Start()
    {
        vida = 100;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Hit(int damage)
    {
        vida -= damage;
        VerifyIfDead();
    }

    void VerifyIfDead()
    {
        if (vida <= 0)
        {
            var particle = GetComponent<ParticleSystem>();
            particle.Play();
            Destroy(gameObject, particle.main.duration);
        }
    }
}
