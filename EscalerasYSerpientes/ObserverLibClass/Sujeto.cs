using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibClass
{
    public abstract class Sujeto
    {

        List<IObservador> obs=new List<IObservador> ();

        
        public void SuscribirObservador(IObservador ob)
        {
            obs.Add(ob);
        }

        public void DesuscribirObservador(IObservador ob)
        {
            obs.Remove(ob);
        }

        public void NotificarATodosSobrePosicion()
        {
            foreach (IObservador ob in obs)
            {
                ob.NotificarCambioPosicion(this);
            }
        }
    }
}
