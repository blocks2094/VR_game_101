using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleTileMap : MonoBehaviour
{
    public GameObject tile_001;
    public GameObject tile_002;                                         //������ �������� ����Ƽ �ν����� â���� �Է� �޴´�.

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 20; i++)
        {
            for(int j = 0; j < 10; j++)                                  //instantiate �Լ��� Prefabs�� �����ϴ� �Լ� return �ִ�. (temp�� �Է�)
            {
                GameObject temp = (GameObject)Instantiate(tile_001);    //temp �Է¹޴� ������Ʈ�� ��ġ ���� (x => i �̰� z => j) �̴�.
                temp.transform.position = new Vector3(i, 0, j);
            }

            for (int j = 10; j < 20; j++)                                  //instantiate �Լ��� Prefabs�� �����ϴ� �Լ� return �ִ�. (temp�� �Է�)
            {
                GameObject temp = (GameObject)Instantiate(tile_002);    //temp �Է¹޴� ������Ʈ�� ��ġ ���� (x => i �̰� z => j) �̴�.
                temp.transform.position = new Vector3(i, 0, j);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}