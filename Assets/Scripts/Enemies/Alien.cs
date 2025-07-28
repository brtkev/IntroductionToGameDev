using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class Alien : Enemy
{
   
    
    // Start is called before the first frame update
    void Start()
    {
        attackMessage = "has shot a lazer beam at";
        defeatMessage = "has pulverized";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Attack(string enemy)
    {
        base.Attack(enemy);   
        Debug.Log(name + " has repositioned");
    }

    public override void DefeatMessage(string enemy)
    {
        base.DefeatMessage(enemy);
        Debug.Log(name + " has reloaded his lazer gun");
    }
}
