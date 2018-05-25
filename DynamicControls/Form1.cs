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
        Color[] colorSelect;
        Color defaultBackColor;
        int incrementalNumber;
        int buttonsOnScreen;
        public GUI()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            colorSelect = new Color[] { Color.LightGreen, Color.Orange, Color.Red };
            defaultBackColor = colorSelect[0];
            incrementalNumber = 0;
            buttonsOnScreen = 0;
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
            newControl.Text = (++incrementalNumber).ToString();
            newControl.Click += Control_Click;

            Controls.Add(newControl);
            countElementsOnScreen.Text = $"{(++buttonsOnScreen).ToString()} buttons";

            newControl.BringToFront();
            
        }

        private void Control_Click(object sender, EventArgs e)
        {
            Control currentControl = (Control)sender;

            //Farbwechsel und entfernen
            if (currentControl.BackColor == colorSelect[0])
            {
                currentControl.BackColor = colorSelect[1];
            }
            else if (currentControl.BackColor == colorSelect[1])
            {
                currentControl.BackColor = colorSelect[2];
            }
            else
            {
                Controls.Remove(currentControl);
                currentControl.Click -= Control_Click;
                countElementsOnScreen.Text = $"{(--buttonsOnScreen).ToString()} buttons";
            }
        }
    }
}
