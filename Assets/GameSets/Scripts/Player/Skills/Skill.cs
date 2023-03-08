using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SkillsType
{
    Short, Medium, Long
}

public class Skill: MonoBehaviour
{
    public float distance = 1;
    public float speed = 1;
    public float damage = 1;
    public SkillsType type = SkillsType.Short;
}
