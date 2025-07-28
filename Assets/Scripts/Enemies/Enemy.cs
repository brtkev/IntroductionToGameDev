using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    
    public List<string> skills;
    public List<string> weaknesses;

    public string attackMessage = "has attacked";
    public string defeatMessage = "has defeated";
   
    // Start is called before the first frame update
    void Start()
    {
        //this.name = "Enemy";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public virtual void Attack(string enemy)
    {
        var attackMessageWords = new List<string>
        {
            name, attackMessage, enemy
        };
        
        Debug.Log(string.Join(" ", attackMessageWords));
    }

    public virtual void DefeatMessage(string enemy)
    {
        var defeatMessageWords = new List<string>
        {
            name, defeatMessage, enemy
        };
        
        Debug.Log(string.Join(" ", defeatMessageWords));
    }

    public void AddSkill(string skill)
    {
        // Debug.Log("skill: " + skill + " added" );
        skills.Add(skill);
    }

    public void AddSkills(List<string> skillList)
    {
        foreach (var skill in skillList)
        {
           
            AddSkill(skill);
        }
    }

    public void AddWeakness(string weakness)
    {
        //Debug.Log("weakness: " + weakness + " added" );
        weaknesses.Add(weakness);
    }
    
    public void AddWeaknesses(List<string> weaknessList)
    {
        foreach (var weakness in weaknessList)
        {
            AddWeakness(weakness);
        }
    }

    public void ShowSkills()
    {
        
        Debug.Log(name + " " + "Skills: " + string.Join(", ", skills));
    }
    
    public void ShowWeaknesses()
    {
        
        Debug.Log(name + " " + "weaknesses: " + string.Join(", ", weaknesses));
    }
}
