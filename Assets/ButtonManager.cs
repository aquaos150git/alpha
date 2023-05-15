using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject[] elements = new GameObject[2];
    public void OnClick(int index) //передайте в параметре номер кнопки, которую нажали (от 0 до 14)
    {
        for (int i = 0; i < elements.Length; i++)
        {
            if (i == index) //включаем нужный элемент
            {
                elements[i].SetActive(true);
            }
            else //отключаем остальные элементы
            {
                elements[i].SetActive(false);
            }
        }
    }
}
