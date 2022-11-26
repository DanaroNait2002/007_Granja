using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creation_Items : MonoBehaviour
{
    public enum StateSelector
    {
        Waiting,
        SelectionMove,
        Moving,
        Realease,
        SelectTypeCreation,
        CreationTree01,
        CreationTree02,
        CreationBarn,
        CreationFlower,
    }
    
    [SerializeField]
    StateSelector currentState = StateSelector.Waiting;

    [SerializeField]
    GameObject creationCanvas, selectedItem;

    Vector2 mousePos;

    private void Update()
    {
        switch (currentState) 
        {
            case StateSelector.Moving:
                MoveItem();
                break;

            case StateSelector.SelectionMove:
                SelectedItem();
                break;

            case StateSelector.Realease:
                Realease(); 
                break;
        }
    }

    public void CreatingItem(GameObject prefab)
    {
        selectedItem = Instantiate(prefab, Vector3.zero, Quaternion.identity);

        currentState = StateSelector.Moving;
    }

    public void SelectedItem()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(pos);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.tag.Equals("Creation"))
                {
                    selectedItem = hitInfo.collider.gameObject;

                    switch (currentState)
                    {
                        case StateSelector.SelectionMove:
                            currentState = StateSelector.Moving;
                            break;
                    }

                    Cursor.visible = false;
                }
            }
        }
    }

    public void MoveItem()
    {
        Vector3 pos = Input.mousePosition;
        Ray rayo = Camera.main.ScreenPointToRay(pos);
        RaycastHit hitInfo;

        selectedItem.SetActive(false);

        if (Physics.Raycast(rayo, out hitInfo))
        {
            selectedItem.transform.position = hitInfo.point /*+ ((Vector3.up * selectedItem.transform.localScale.y) * 1.5f)*/;
        }

        selectedItem.SetActive(true);

        if (Input.GetMouseButtonDown(0))
        {
            currentState = StateSelector.Realease;
        }
    }

    public void Realease()
    {
        selectedItem = null;

        currentState = StateSelector.Waiting;

        Cursor.visible = true;
    }
}
