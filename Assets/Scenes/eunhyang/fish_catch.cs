using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish_catch : MonoBehaviour
{
    private fish_move fish;
    // Start is called before the first frame update
    void Start()
    {
        //fish = GetComponent<fish_move>(); // fish move 스크립트 제어하기 위함
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){ // socet에 부딪혔을 때 물고기 움직임 멈추게 하기
        fish = other.GetComponent<fish_move>();
        Debug.Log("잡혔다1!!");
        fish.enabled = false; // move 스크립트 비활성화
        
        
    }

}
