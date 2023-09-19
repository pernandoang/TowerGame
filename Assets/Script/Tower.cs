using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    [SerializeField] private SpriteRenderer _towerPlace;
    [SerializeField] private SpriteRenderer _towerHead;

    [SerializeField] private int _shootPower = 1;
    [SerializeField] private float _shootDistance = 1f;
    [SerializeField] private float _shootDelay = 5f;
    [SerializeField] private float _bulletSpeed = 1f;
    [SerializeField] private float _bulletSplashRadius = 0f;

    public Vector2? PlacePosition1 { get; private set; }
    public void SetPlacePosition(Vector2? newPosition)
    {
        PlacePosition = newPosition;
    }
    public void LockPlacement()
    {
        transform.position = (Vector2)PlacePosition;
    }

    public void ToggleOrderInLayer(bool toFront)
    {
        int orderInLayer = toFront ? 2 : 0;
        _towerPlace.sortingOrder = orderInLayer;
        _towerHead.sortingOrder = orderInLayer;
    }


    public Vector2? PlacePosition { get; private set; }


    public Sprite GetTowerHeadIcon()
    {
        return _towerHead.sprite;
    }

    public void SetPlacePosition1(Vector2? newPosition)
    {
        PlacePosition = newPosition;
    }

}
