using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class TerrainCreator : MonoBehaviour
{
    public SpriteShapeController shape;
    public int scale;
    public int numberofPoints = 150;

    //public float ranMin;
   // public float ranMax;

    // Start is called before the first frame update
    void Start()
    {
        shape = GetComponent<SpriteShapeController>();

        shape.spline.SetPosition(2, shape.spline.GetPosition(2) + Vector3.right * scale);
        shape.spline.SetPosition(3, shape.spline.GetPosition(3) + Vector3.right * scale);

        float distanceBetweenPoints = (float)scale / (float)numberofPoints;


        for (int i = 0; i < numberofPoints; i++)
        {
            float xPos = shape.spline.GetPosition(i + 1).x + distanceBetweenPoints;
            shape.spline.InsertPointAt(i + 2, new Vector3(xPos, shape.spline.GetPosition(i+1).y + Random.Range(-1, 2) , 0));
        //Mathf.PerlinNoise(i * Random.Range(5,16)
    }

        for (int i = 2; i < numberofPoints+2; i++)
        {
            shape.spline.SetTangentMode(i, ShapeTangentMode.Continuous);
            shape.spline.SetLeftTangent(i, new Vector3(-1, 0, 0));
            shape.spline.SetRightTangent(i, new Vector3(1, 0, 0));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
