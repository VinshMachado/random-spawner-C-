using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class RandomObjectExample : MonoBehaviour
{


    //object to be spawnned randomly//
    //just attach game object  to this script//
    public GameObject debries;
    private int randomx,randomy;
    
    void Start()
    {
        
    
       for(int i=0;i<20;i++){
        Vector3 ran=new Vector3(
            //enter range from x and y axis to be spaenned //
    randomx=UnityEngine.Random.Range(-63,63),
    randomy=UnityEngine.Random.Range(-58,58),0);
    Instantiate(debries,new Vector3(randomx,randomy,0), Quaternion.identity);
        debries.transform.localScale=new Vector3(0,0,randomx);
       }
        
        
     
    }

    
 
}