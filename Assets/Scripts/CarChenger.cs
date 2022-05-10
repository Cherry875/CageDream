using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChenger : MonoBehaviour
{

    public Car startCar;
    public Icon myIcon;
    public Car currentCar;


   public void moveTo(Car goalCar){
        currentCar = goalCar;
        Debug.Log(goalCar.getCarNum()+"号車に移動");
        this.transform.localPosition = new Vector2(0,0) - goalCar.position()+ new Vector2(0,100);
    }

    private void Start(){
      moveTo(startCar);
    }

    public void goLeft(){
      if(currentCar != currentCar.leftCar){
        myIcon.setX(currentCar.leftCar.rightX);
        moveTo(currentCar.leftCar);
        }else{
          myIcon.setX(currentCar.leftX);
        }
    }

    public void goRight(){
      if(currentCar != currentCar.rightCar ){
        myIcon.setX(currentCar.rightCar.leftX);
        moveTo(currentCar.rightCar);
      }else{
        myIcon.setX(currentCar.rightX);
        }
    }

}
