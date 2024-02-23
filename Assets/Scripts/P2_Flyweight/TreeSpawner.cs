using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using Random = UnityEngine.Random;

public class TreeSpawner : MonoBehaviour
{

    private TreeSeasonColors _treeSeasonColors;
    private Tree _tree;
    public Tree TreePrefab;
    private float _currentCooldown;
    
    const float _totalCooldown = 0.2f;

    public void LoadColorInfos()
    {
        var fileContents = Resources.Load<TextAsset>("treeColors").text;
        this._treeSeasonColors = JsonUtility.FromJson<TreeSeasonColors>(fileContents);
    }

    private void Start()
    {
       LoadColorInfos();
    }

    void FixedUpdate()
    {
        
        this._currentCooldown -= Time.deltaTime;
        if (this._currentCooldown <= 0f)
        {
            this._currentCooldown += _totalCooldown;
            SpawnTree();
            
        }
       
    }
    
    

  public  void SpawnTree()
    {
        
        var randomPositionX = Random.Range(-6f, 6f);
        var randomPositionY = Random.Range(-6f, 6f); 
        var newSpawn  =  Instantiate(this.TreePrefab, new Vector2(randomPositionX, randomPositionY), Quaternion.identity);
        // pass flyweight to tree

        newSpawn._treeColors = _treeSeasonColors;

    }
}
