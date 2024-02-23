using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using Random = UnityEngine.Random;

public class TreeSpawner : MonoBehaviour
{

    private TreeSeasonColors _treeSeasonColors;
   
    public Tree TreePrefab;
    private float _currentCooldown;
    
    const float _totalCooldown = 0.2f;

    private void Start()
    {
        throw new NotImplementedException();
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
    
    
    public void Flyweight(TreeSeasonColors treeSeasonColors)
    {
        treeSeasonColors = _treeSeasonColors;
    }
    
  public  void SpawnTree()
    {
        
        var randomPositionX = Random.Range(-6f, 6f);
        var randomPositionY = Random.Range(-6f, 6f); 
        var newSpawn  =  Instantiate(this.TreePrefab, new Vector2(randomPositionX, randomPositionY), Quaternion.identity);
        // pass flyweight to tree
      
    }
}
