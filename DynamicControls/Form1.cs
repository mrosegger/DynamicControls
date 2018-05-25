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
        bool colorAlreadySet;
        public GUI()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            colorSelect = new Color[] { Color.LightGreen, Color.Orange, Color.Red, Color.Blue};
            defaultBackColor = colorSelect[0];
            incrementalNumber = 0;
            buttonsOnScreen = 0;
        }

        private void GUI_MouseClick(object sender, MouseEventArgs e)
        {
            // Abmessungen der Controls festlegen
            Size controlSize = new Size(30, 30);
            Point startPoint = new Point(e.X-controlSize.Width/2, e.Y-controlSize.Height/2);
            Control newControl;
            if (selButton.Checked)
            {
                newControl = new Button();
            }
            else if (selTextbox.Checked)
            {
                newControl = new TextBox();
            }
            else
            {
                newControl = new Label();
            }
            newControl.BackColor = defaultBackColor;
            newControl.Size = controlSize;
            newControl.Location = startPoint;
            newControl.Text = (++incrementalNumber).ToString();
            newControl.Click += Control_Click;

            Controls.Add(newControl);
            countElementsOnScreen.Text = $"{(++buttonsOnScreen).ToString()} controls";

            newControl.BringToFront();
            
        }

        private void Control_Click(object sender, EventArgs e)
        {
            Control currentControl = (Control)sender;
            colorAlreadySet = false;
            //Farbwechsel und entfernen
            for (int index = 0; index < colorSelect.Length; index++)
            {
                if (currentControl.BackColor == colorSelect[colorSelect.Length - 1] && !colorAlreadySet)
                {
                    Controls.Remove(currentControl);
                    currentControl.Click -= Control_Click;
                    countElementsOnScreen.Text = $"{(--buttonsOnScreen).ToString()} controls";
                    colorAlreadySet = true;
                }
                else if (currentControl.BackColor == colorSelect[index] && !colorAlreadySet)
                {
                    currentControl.BackColor = colorSelect[index+1];
                    colorAlreadySet = true;
                }
            }
        }

    }
}
