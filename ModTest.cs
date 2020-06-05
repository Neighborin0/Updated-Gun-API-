using System;
using System.Collections;
using Gungeon;
using MonoMod;
using UnityEngine;
using System.Collections.Generic;

namespace BasicGun
{
   
    public class ModTest : ETGModule
    {
     
        public override void Init()
        {
           
        
            
        }

      
        public override void Start()
        {
            BasicGun.Add();
            Tools.Init();
            ETGModConsole.Log("shit", false);
       

        }

      
        public override void Exit()
        {
           
        }
    }
}
