using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySpace : MonoBehaviour {

    [SerializeField] public int height = 10;
    [SerializeField] public int width = 8;
    [SerializeField] public int score = 0;
    [SerializeField] public int combo = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void GameLoop(){
        bool nextTurn = false;
        while (!nextTurn)
        {
            checkFall();
            nextTurn = checkScore();
            SpawnLine();
        }
        PlayerTurn();
       

    }

    void PlayerTurn(){ 

    }

    void checkFall(){
        for(each line){
            for(each box){
                if(can fall){
                    fall();
                }
            }
        }
    }

    bool checkScore(){
    bool result = true;
        for(eachLine){
        int count = 0;
            for(each box){
            count += box.size;
            }
            if(count == width){
                score++;
                combo++;
            result = false;
            }
        }
    return result;
    }

    void SpawnLine(){

    }

}
