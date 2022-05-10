using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{
    public CarChenger carChanger;

    private void Update() {
        // 自身が生成したオブジェクトだけに移動処理を行う
        if (true) {
            var pos = transform.position;
            var newX = Mathf.Min(pos.x + 6f * Time.deltaTime * Input.GetAxis("Horizontal"),750);
        
            pos.x=newX;
            
            transform.position = pos;
            if( newX > carChanger.currentCar.rightX){
                carChanger.goRight();
            }else if(newX < carChanger.currentCar.leftX){
                carChanger.goLeft();
            }
        }
    }

    public void setX(float newX){
        var pos = transform.position;
        pos.x = newX;
        transform.position = pos;
    }
}
