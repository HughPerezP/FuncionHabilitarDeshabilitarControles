using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FuncionHabilitarDeshabilitarControles
{
    public static class FuncionesBasicas
    {

        public static void BloqueadorCajasdeTexto(List<Control> ListaTextbox, Boolean Habilitado)
        {
            foreach (Control txt in ListaTextbox)
            {
                txt.Enabled = Habilitado;
            }
        }
    }
}
