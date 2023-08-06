using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime;
    private float timer = 0;
    public GameObject Pipe;
    public float height;
    private List<GameObject> pipesList = new List<GameObject>();
    public float speed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(Pipe);
            pipesList.Add(newPipe);
            newPipe.transform.position = new Vector3(1, Random.Range(-height, height), 0);
            Destroy(newPipe, 4);
            timer = 0;

        }
        if (pipesList.Count > 0)
        {
            if (pipesList[0] == null)
            {
                pipesList.RemoveAt(0);
            }
            foreach (GameObject curPipe in pipesList)
            {
                curPipe.transform.position += Vector3.left * speed * Time.deltaTime;
                if (curPipe.transform.position.x <= -0.06 && curPipe.transform.position.x > -0.068) { Score.score += 1; }
            }
        }
        timer += Time.deltaTime;
    }
}
