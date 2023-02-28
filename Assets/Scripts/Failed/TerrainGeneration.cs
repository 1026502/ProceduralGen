using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGeneration : MonoBehaviour
{
    public int width, height;
    public GameObject dirt, grass;
    // Start is called before the first frame update
    void Start()
    {
        Generate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Generate()
    {

        for (int i = 0; i < width; i++)
        {
            int minHeight = height - 1;
            int maxHeight = height + 2;

            height = Random.Range(minHeight, maxHeight);

            if (height <= 0)
            {
                //prevent irregular terrain
                height = 1;
            }

            

            for(int j = 0; j < height; j++)
            {
                spawnObj(dirt, i, j);
            }

            spawnObj(grass, i, height);
        }
    }

    void spawnObj(GameObject obj, int width, int height)
    {
        obj = Instantiate(obj, new Vector2(width, height), Quaternion.identity);
        obj.transform.parent = this.transform;
    }
}
