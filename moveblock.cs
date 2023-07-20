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
    public GameObject[] game = new GameObject[7];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lmove(); // 마나피스 왼쪽으로 이동
        rmove(); // 마나피스 오른쪽으로 이동
        dmove(); // 마나피스 아래쪽으로 이동
        rotate(); // 마나피스 회전
    }
    bool move(){ // 이동할때 벽을 감지해서 벽을 넘으면 false 반환
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
    void checkline(){ // 라인체크
        for(int i=height-1; i>=0; i--){
            if(maxline(i)){
                delline(i);
                down(i);
            }
            else if(gameover(i)){ // i보다 높을때 블럭이 감지되면 움직이지 못하게함
                for(int j=0; j<width; j++){
                    if(grid[j,i] != null){
                        for(int e=0; e<7; e++){
                            game[e].GetComponent<moveblock>().enabled=false;
                        }
                    }
                }
            }
        }
    }
    bool maxline(int i){ // 줄이 꽉 차면 false 반환
        for(int j=0;j<width;j++){
            if(grid[j,i]==null){
            return false;
            }
        }
        return true;
    }
    bool gameover(int i){ // 높이가 20 이상이면 true 반환
        if(i>=20){
            return true;
        }
        return false;
    }
    void delline(int i){ // 줄 삭제
        for(int j=0;j<width; j++){
            Destroy(grid[j,i].gameObject);
            grid[j,i]=null;
            curmana+=0.2f;
        }
    }
    void down(int i){ // 줄 삭제후 삭제한만큼 줄 내리기
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
    void addtogrid(){ // 구역 추가
        foreach (Transform children in transform)
        {
            int X=Mathf.RoundToInt(children.transform.position.x);
            int Y=Mathf.RoundToInt(children.transform.position.y);
            grid[X,Y]=children;
        }
    }
    void lmove(){ 
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            transform.position += new Vector3(-1, 0, 0);
            if(!move()){
            transform.position -= new Vector3(-1, 0, 0);
            }
        }
    }
    void rmove(){
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            transform.position += new Vector3(1, 0, 0);
            if(!move()){
            transform.position -= new Vector3(1, 0, 0);
            }
        }
    }
    void dmove(){
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
    void rotate(){
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
    }
}
