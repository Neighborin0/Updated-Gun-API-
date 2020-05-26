using System;
using UnityEngine;

namespace BasicGun
{
    
    internal class BasicGunProjectile : MonoBehaviour
    {
       
        public void Start()
        {
            this.projectile = base.GetComponent<Projectile>();
            this.player = (this.projectile.Owner as PlayerController);
            Projectile proj = this.projectile;
            //This determines what sprite you want your projectile to use.
            projectile.sprite.GetSpriteIdByName("jpxfrd_projectile_001");
         
        }

 
        private Projectile projectile;

        private PlayerController player;
    }
}
