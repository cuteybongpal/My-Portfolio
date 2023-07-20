using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveblock : MonoBehaviour
{
    public static float curmana=0f;
    private float pretime;
    public float falltime =1.0f;
    public Vector3 rotationPoint;
    public float l=0;
    public float r=0;
    public float d=0;
    public static int height=24;
    public static int width=10;
    private static Transform[,] grid=new Transform[width, height];
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount==0){
            Destroy(gameObject);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            d+=Time.deltaTime;
            if(d>=0.03f){
                d=0f;
                transform.position += new Vector3(0, -1, 0);
            if(!move()){
                transform.position -= new Vector3(0, -1, 0);
            }
            }
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            transform.position += new Vector3(-1, 0, 0);
            if(!move()){
            transform.position -= new Vector3(-1, 0, 0);
            }
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            transform.position += new Vector3(1, 0, 0);
            if(!move()){
            transform.position -= new Vector3(1, 0, 0);
            }
        }
        if(Input.GetKeyDown(KeyCode.X)){
            transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0,0,1), -90);
            if(!move()){
                transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0,0,1), 90);
            }
        }
        if(Input.GetKeyDown(KeyCode.Z)){
            transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0,0,1), 90);
            if(!move()){
                transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0,0,1), -90);
            }
        }
        if(Time.time-pretime > (Input.GetKey(KeyCode.DownArrow) ? falltime/10 : falltime)){
            transform.position += new Vector3(0, -1, 0);
            if(!move()){
            transform.position -= new Vector3(0, -1, 0);
            addtogrid();
            checkline();
            this.enabled=false;
            FindObjectOfType<bag>().baag();
            }
            pretime=Time.time;
        }
    }
    bool move(){
        foreach (Transform children in transform)
        {
            int X=Mathf.RoundToInt(children.transform.position.x);
            int Y=Mathf.RoundToInt(children.transform.position.y);
            if(X<0 || X>=width || Y<0 || Y>=height){
                return false;
            }
            if(grid[X,Y]!=null)
            return false;
        }
        return true;
    }
    void checkline(){
        for(int i=height-1; i>=0; i--){
            if(maxline(i)){
                delline(i);
                down(i);
            }
        }
    }
    bool maxline(int i){
        for(int j=0;j<width;j++){
            if(grid[j,i]==null){
            return false;
            }
        }
        return true;
    }
    void delline(int i){
        for(int j=0;j<width; j++){
            Destroy(grid[j,i].gameObject);
            grid[j,i]=null;
            curmana+=0.2f;
        }
    }
    void down(int i){
        for(int y=i; y<height; y++){
            for(int j=0; j<width; j++){
                if(grid[j,y]!=null){
                    grid[j,y-1]=grid[j,y];
                    grid[j,y]=null;
                    grid[j,y-1].transform.position-=new Vector3(0,1,0);
                }
            }
        }
    }
    void addtogrid(){
        foreach (Transform children in transform)
        {
            int X=Mathf.RoundToInt(children.transform.position.x);
            int Y=Mathf.RoundToInt(children.transform.position.y);
            grid[X,Y]=children;
        }
    }
}
