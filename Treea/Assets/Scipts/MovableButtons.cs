using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MovableButtons : MonoBehaviour, IDragHandler, IEndDragHandler
{

    public List<GameObject> PanelListesi = new List<GameObject>();
    public List<Button> ButonListesi = new List<Button>();
    private bool isDragging = false;
    private Transform draggedTransform;

    [ContextMenu("Alan Ekle")]
    void AlanEkle()
    {
        GameObject yeniAlan = new GameObject("Yeni Alan");
        PanelListesi.Add(yeniAlan);
    }

    [ContextMenu("Buton Ekle")]
    void ButonEkle()
    {
        GameObject yeniButonObj = new GameObject("Yeni Buton");
        Button yeniButon = yeniButonObj.AddComponent<Button>();
        ButonListesi.Add(yeniButon);
    }

    void Start()
    {
        foreach (var nesne in PanelListesi)
        {
            Debug.Log("Zaten Mevcut: " + nesne.name);
        }
        foreach (var nesne in ButonListesi)
        {
            Debug.Log("Zaten Mevcut: " + nesne.name);
        }
    }

    void Update()
    {
        // Update logic here
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isDragging)
        {
            if (draggedTransform != null)
            {
                draggedTransform.position = eventData.position;
            }
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (isDragging)
        {
            isDragging = false;
            if (draggedTransform != null)
            {
                Ray ray = Camera.main.ScreenPointToRay(eventData.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    GameObject droppedObject = hit.collider.gameObject;
                    if (droppedObject.CompareTag("PanelTag"))
                    {
                        Vector3 tempPosition = draggedTransform.position;
                        draggedTransform.position = droppedObject.transform.position;
                        droppedObject.transform.position = tempPosition;
                    }
                }
                draggedTransform = null;
            }
        }
    }

    public void StartDrag(Transform draggedObject)
    {
        isDragging = true;
        draggedTransform = draggedObject;
    }

}
