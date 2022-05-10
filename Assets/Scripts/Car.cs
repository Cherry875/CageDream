using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    Vector2 place;
    public int carNum;
    public Car rightCar;
    public Car leftCar;
    bool canMoveTo;

    public float leftX = 7.9f;
    public float rightX = -7.9f;

    void Start()
    {
       place = this.transform.localPosition;
    }

    public int getCarNum(){
        return this.carNum;
    }

    public Vector2 position(){
        return place;
    }

}
