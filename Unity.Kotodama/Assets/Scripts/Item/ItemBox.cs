﻿
using UnityEngine;
using UnityEngine.UI;


// TIPS: プレハブに設定、プレハブ自身のオブジェクトを登録する
public class ItemBox : MonoBehaviour {

  [SerializeField]
  Image _image = null;
  public Image image { get { return _image; } }

  [SerializeField]
  Text _itemName = null;
  public Text itemName { get { return _itemName; } }

  [SerializeField]
  Text _itemInfo = null;
  public Text itemInfo { get { return _itemInfo; } }
}
