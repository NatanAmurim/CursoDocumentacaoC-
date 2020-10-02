using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTeste : ModificadoresTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste modificadoresTeste = new ModificadoresTeste();
            modificadoresTeste.MetodoPublico();
            MetotoProtected();

        }
    }

    class ModificadoresTeste
    {
        public void MetodoPublico()
        {

        }

        private void MetodoPrivate()
        {

        }

        protected void MetotoProtected()
        {

        }

        internal void MetodoInterno() 
        { 
            //Visivel apenas do projeto ao qual ele pertence.
        }

    }
}
