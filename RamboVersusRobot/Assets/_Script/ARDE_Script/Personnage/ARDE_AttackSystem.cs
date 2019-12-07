﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARDE_AttackSystem : MonoBehaviour
{
    public Transform mySelf = null;
    public int damage = 1;
    public float lifeTime = 0.3f;
    public float knockback = 40f;

    private void Start()
    {
        mySelf = this.GetComponent<Transform>();
    }

    void Update()
    {
        SelfDestructionIn(lifeTime);
    }

    private void SelfDestructionIn(float lifeTime)
    {
        //Si je ne suis trop vieux
        if (lifeTime > 0)
        {
            //je vis
            lifeTime -= Time.deltaTime;
        }
        else //sinon
        {
            //je meurt
            Destroy(gameObject);
        }
    }

}
