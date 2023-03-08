using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillFireball : MonoBehaviour
{
    Skill skill;

    [SerializeField]
    GameObject pref;

    [SerializeField]
    AudioSource song;

    // Start is called before the first frame update
    void Start()
    {
        skill= new Skill();
        skill.damage = 50;
        skill.distance = 15;
        skill.speed = 15;
        skill.type = SkillsType.Medium;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            FireballController shot = Instantiate(pref, Player.player.shotPlace.position , Player.player.transform.rotation).GetComponent<FireballController>() ;
            shot.Setup(transform.rotation.eulerAngles.normalized);
            song.Play();
        }
    }
}
