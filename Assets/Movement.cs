using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed;

    public float x;

    public float y;

    public Transform[] positions;
    public int index;

    IEnumerator Start()
    {
        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(.2f);
           
            //to check how much distance is remaining -> a magnitude 
            // simply toward complicated vector 3 each axis. 
            
            // (float)Vector3.Distance(vector3,vector3)

           
            while (Vector3.Distance(transform.position, positions[i].position)>.1f)
            {
                transform.position = Vector3.MoveTowards(transform.position,positions[i].position,speed*Time.deltaTime);
                yield return null; // 
            }
            if (i == 3)
            {
                i = -1;
            }
        }
    }
    // Update is called once per frame

  
    void Update()
    {
       
       /* x = Input.GetAxis("Horizontal")*speed;
        y = Input.GetAxis("Vertical") * speed;
        Vector3 pos = new Vector3(x, 0, y).normalized*Time.deltaTime;
        Debug.Log(pos);
      transform.position += pos;*/
       // this.transform.Rotate( new Vector3(0,0,speed)*Time.deltaTime);
      // this.transform.localScale += new Vector3(speed*Time.deltaTime,0, 0);
      
    }

    void Add(int a, int b)
    {
        int c = a + b;
        Debug.Log(c);
    }
}
