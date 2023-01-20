using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroudMusic : MonoBehaviour
{
    private static BackgroudMusic backGroundMusic;

    void Awake(){
        if(backGroundMusic==null){
            backGroundMusic=this;
            DontDestroyOnLoad(backGroundMusic);
        }
        else{
            Destroy(gameObject);
        }
    }
}
