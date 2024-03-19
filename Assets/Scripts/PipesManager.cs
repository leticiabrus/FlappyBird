using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class PipesManager : MonoBehaviour
{
    public GameObject pipeModel;
    public Transform spawnPoint;
    public float interval;
    private float currentTime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()

    {

        currentTime += Time.deltaTime;
        if (currentTime > interval)

        {

            CreatePipe();
            currentTime = 0f;



        }

    }


    void CreatePipe()
    {

        

       var pipeGameObject = Instantiate (pipeModel, spawnPoint.position, Quaternion.identity);
       var pipeTransform = pipeGameObject.GetComponent<Transform>();

        float y = Random.Range(-1.6f, 0.26f);

        pipeTransform.position = new Vector3(spawnPoint.position.x, y);
            

    }

    


}
