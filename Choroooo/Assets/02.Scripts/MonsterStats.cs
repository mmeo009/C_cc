using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStats : MonoBehaviour
{
    protected MonsterSet Mon;

    protected virtual void StatSetting(int monsterType, int attackType, int stage, int hp, float moveSpeed, float attackSpeed)
    {
        Mon.MonT = monsterType;
        Mon.AT = attackType;
        Mon.Stage = stage;
        Mon.HP = hp;
        Mon.MS = moveSpeed;
        Mon.AS = attackSpeed;
    }
    protected struct MonsterSet
    {
        public int MonT;
        public int AT;
        public int Stage;
        public int HP;
        public float MS;
        public float AS;
    }
}
