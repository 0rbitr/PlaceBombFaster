using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace PlaceBombFaster
{
    public abstract class GamePhysicalObject:GameObject
    {
        public int HP { get; set; }
        
        public Decimal LocationX { get;  set; }
        public Decimal LocationY { get;  set; }
        public int DamageBlock { get;  set; }
        protected DrawingImage Texture;
        public List<GameEffect> Effects = new List<GameEffect>();
      //  private DestroyingEffect destroyingEffect;

        public GamePhysicalObject():this(0,0,null,1,0)
        {
            
        }
        public GamePhysicalObject(int x, int y, DrawingImage texture, int hp, int damageBlock)
        {
            LocationX = x;
            LocationY = y;
            Texture = texture;
            HP = hp;
            DamageBlock = damageBlock;
        }

        public virtual void SetDamage(int damage)
        {
            HP = damage > DamageBlock ? damage - DamageBlock : HP;
        }

       /* protected virtual void Destroy()
        {

        }*/
    }
}
