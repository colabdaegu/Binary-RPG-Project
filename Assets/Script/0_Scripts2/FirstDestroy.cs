using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDestroy : MonoBehaviour
{
    // 최초 프리팹 생성 시 텍스트 미표출 오류로 인해 첫 프리팹은 즉시 삭제 후 넘김
    
    public string targetObjectName1;    // box1(Clone)
    public string targetObjectName2;    // box2(Clone)
    public string targetObjectName3;    // box3(Clone)
    public string targetObjectName4;    // box4(Clone)
    public string targetObjectName5;    // box5(Clone)

    // 임시 콜라이더용 오브젝트와 첫 프리팹 닿을 시
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName1 || collision.gameObject.name == targetObjectName2 || collision.gameObject.name == targetObjectName3 || collision.gameObject.name == targetObjectName4 || collision.gameObject.name == targetObjectName5)
        {
            // 임시 콜라이더용 오브젝트 삭제
            Destroy(this.gameObject);
        }
    }
}
