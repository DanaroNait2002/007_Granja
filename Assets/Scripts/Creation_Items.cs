using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creation_Items : MonoBehaviour
{
    [SerializeField]
    GameObject selectedItem;

    private void Update()
    {
        if (selectedItem != null)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //if (Physics.Raycast, out hit, Math.Infinity)
        }
    }

    public void Create_Item(GameObject prefab)
    {
        Instantiate(prefab, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        prefab = selectedItem;
    }
}
