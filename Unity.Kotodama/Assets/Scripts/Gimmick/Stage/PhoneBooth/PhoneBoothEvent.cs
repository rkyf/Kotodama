﻿
using UnityEngine;

/// <summary> 公衆電話エリア専用イベント </summary>
public class PhoneBoothEvent : SingletonBehaviour<PhoneBoothEvent> {

  [SerializeField]
  RootManager[] _rootObjects = null;

  [SerializeField]
  [Tooltip("イベント開始時に有効化したいアイテムを指定")]
  ItemCollider _amulet = null;

  /// <summary> 敵キャラを出現させる </summary>
  public void AwakeEvent() {
    _amulet.gameObject.SetActive(true);

    var manager = EnemyManager.instance;
    foreach (var root in _rootObjects) { manager.CreateEnemy(root.spots); }
  }
}
