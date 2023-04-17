using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjactileMove : MonoBehaviour
{
    public Vector3 launchDirection;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Wall")
        {
            Destroy(this.gameObject);
        }
        if(collision.gameObject.name == "Monster")
        {
            collision.gameObject.GetComponent<MonsterController>().Damanged(1);
        }
    }
    private void FixedUpdate()
    {
        //�ð���� �̵� �� float ������ ����
        float moveAmount = 3 * Time.fixedDeltaTime;
        //launchDirection �������� �߻�ü �̵� (Translate) �̵� ��Ű�� �Լ�
        transform.Translate(launchDirection * moveAmount);
    }
}
