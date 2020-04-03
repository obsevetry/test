using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaFightLibrary
{
    public abstract class Player : IShoot
    {
        // Событие возникающее после выстрела
        protected internal event PlayerStateHandler Shooted;

        protected string _name;
        protected Cell[] _cells;
        protected Ship[] _ships;

        private void CallEvent(PlayerEventArgs e, PlayerStateHandler handler)
        {
            if (e != null)
                handler?.Invoke(this, e);
        }

        protected virtual void AfterShoot(PlayerEventArgs e)
        {
            CallEvent(e, Shooted);
        }

        public virtual void Shoot()
        {
            // Обработка выстрела

            // Дествия после выстрела
            AfterShoot(new PlayerEventArgs());
        }
    }
}
