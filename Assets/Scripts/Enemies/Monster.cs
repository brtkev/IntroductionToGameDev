using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class Monster : Enemy
{
   
    
    // Start is called before the first frame update
    void Start()
    {
        attackMessage = "has punched";
        defeatMessage = "has Knocked out";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Attack(string enemy)
    {
        base.Attack(enemy);   
        Debug.Log(name + " has prepared for another punch");
    }

    public override void DefeatMessage(string enemy)
    {
        base.DefeatMessage(enemy);
        Debug.Log(name + " has made a loud roar!");
    }
}
