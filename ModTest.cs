using System;
using System.Collections;
using Gungeon;
using MonoMod;
using UnityEngine;
using ItemAPI;
using System.Collections.Generic;

namespace FrostAndGunfireItems
{
   
    public class ModTest : ETGModule
    {
     
        public override void Init()
        {
           
        
            
        }

      
        public override void Start()
        {
            FakePrefabHooks.Init();
            ItemBuilder.Init();
            BasicGun.Add();
            ETGModConsole.Log("shit", false);






        }

      
        public override void Exit()
        {
           
        }
    }
}
