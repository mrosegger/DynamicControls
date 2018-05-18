using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Dynamic Controls
 * Dynamic control elements
 * 18.05.2018
 * Max Rosegger*/

namespace DynamicControls
{
    public partial class GUI : Form
    {
        //zentrale Einstellungen/Variablen 
        Color defaultBackColor;
        public GUI()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            defaultBackColor = Color.LightCyan;
        }

        private void GUI_MouseClick(object sender, MouseEventArgs e)
        {
            // Abmessungen der Controls festlegen
            Size controlSize = new Size(30, 30);
            Point startPoint = new Point(e.X-controlSize.Width/2, e.Y-controlSize.Height/2);

            Control newControl = new Button();
            newControl.BackColor = defaultBackColor;
            newControl.Size = controlSize;
            newControl.Location = startPoint;

            Controls.Add(newControl);
            
        }
    }
}
