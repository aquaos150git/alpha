using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject[] elements = new GameObject[2];
    public void OnClick(int index) //��������� � ��������� ����� ������, ������� ������ (�� 0 �� 14)
    {
        for (int i = 0; i < elements.Length; i++)
        {
            if (i == index) //�������� ������ �������
            {
                elements[i].SetActive(true);
            }
            else //��������� ��������� ��������
            {
                elements[i].SetActive(false);
            }
        }
    }
}
