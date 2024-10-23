using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cube;
    public float timer = 0;
   
    [SerializeField]List<GameObject> list;
    private void erupt()
    {
        GameObject blok = Instantiate(Cube);
        blok.AddComponent<movecube>();
        list.Add(blok);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                erupt();
            }
        }
        if (timer >= 3)
        {
            for (global::System.Int32 i = 0; i < 3; i++)
            {
                erupt();
            }
            timer = 0;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {

            while (list.Count > 0)
            {
                Destroy(list[0]);
                list.RemoveAt(0);
            }

        }

    }


}

public class movecube : MonoBehaviour
{
    float speed = 30f;

    private void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}
