using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntradaEjemplo
{
   public partial class Producto :
      MetroFramework.Forms.MetroForm
   {
      public Producto()
      {
         InitializeComponent();
         this.StyleManager = metroStyleManager1;
      }

      private void Producto_Load(object sender, EventArgs e)
      {

      }

      private void metroLabel3_Click(object sender, EventArgs e)
      {

      }

      private void metroTile1_Click(object sender, EventArgs e)
      {

      }

      private void metroToggle1_CheckedChanged(object sender, EventArgs e)
      {
         if(metroToggle1.Checked)
         {
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
         }
         else
         {
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
         }
      }
   }
}
