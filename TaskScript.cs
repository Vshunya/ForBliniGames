using System.Collections.Generic;
using UnityEngine;

public class TaskScript : MonoBehaviour
{
    public GameObject[] TwoArrGO(GameObject[] arr1, GameObject[] arr2)
    {

        List<int> Empty = new List<int>(); // список для хранения индеков null первого массива 
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] == null)
            {
                Empty.Add(i);
            }
        }

        List<int> NotEmpty = new List<int>(); // список для хранения индексов gameObject(ов) второго массива
        for (int i = 0; i < arr2.Length; i++)
        {
            if (arr2[i] != null)
            {
                NotEmpty.Add(i);
            }
        }

        System.Random random = new System.Random();

        while (Empty.Count > 0 && NotEmpty.Count > 0) // пока кол-во элементов в одном из списков не закончиться
        {
            int rndArr1 = random.Next(0, Empty.Count);
            int rndArr2 = random.Next(0, NotEmpty.Count);
            arr1[Empty[rndArr1]] = arr2[NotEmpty[rndArr2]];
            Empty.RemoveAt(rndArr1);
            NotEmpty.RemoveAt(rndArr2);
        }

        return arr1;
    }
}
