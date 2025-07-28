using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public Monster kingKong;
    public Alien marvinElMarciano;
    void Start()
    {
        kingKong.name = "KingKong";
        marvinElMarciano.name = "Marvin";
        
        List<string> kingKongSkills = new List<string>
        {
            "Throw rock", "climb wall", "Super Jump"
        };
        List<string> marvinSkills = new List<string>
        {
            "use antigravity boots", "use lightsaber", "throw granade"
        };
        List<string> kingKongWeaknesses = new List<string>
        {
            "women", "tall buildings", "flying enemies"
        };
        List<string> marvinWeaknesses = new List<string>
        {
            "bugs bunny", "melee enemies", "toonForce"
        };
        
        kingKong.AddSkills(kingKongSkills);
        kingKong.AddWeaknesses(kingKongWeaknesses);
        marvinElMarciano.AddSkills(marvinSkills);
        marvinElMarciano.AddWeaknesses(marvinWeaknesses);
        
        Debug.Log("Kingkong skills:");
        kingKong.ShowSkills();
        Debug.Log("Kingkong weaknesses:");
        kingKong.ShowWeaknesses();
        
        marvinElMarciano.ShowSkills();
        marvinElMarciano.ShowWeaknesses();
        
        kingKong.Attack(marvinElMarciano.name);
        marvinElMarciano.Attack(kingKong.name);
        kingKong.DefeatMessage(marvinElMarciano.name);
        marvinElMarciano.DefeatMessage(kingKong.name);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
