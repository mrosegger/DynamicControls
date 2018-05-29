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
        List<Control> DynamicControls;
        Random rndGEn;
        public GUI()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            colorSelect = new Color[] { Color.LightGreen, Color.Orange, Color.Red, Color.Blue};
            DynamicControls = new List<Control>();
            rndGEn = new Random();
            defaultBackColor = colorSelect[0];
            incrementalNumber = 0;
            buttonsOnScreen = 0;
            DoubleBuffered = Enabled;
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
                ((TextBox)newControl).ReadOnly = true;
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
            DynamicControls.Add(newControl);
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
                    DynamicControls.Remove(currentControl);
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

        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            int maxSpeed = 50;
            foreach (Control currentControl in DynamicControls)
            {
                Rectangle validSpace = GetValidSpace(currentControl);
                Point nextLocation = GetNewLocation(maxSpeed, currentControl, validSpace);
                currentControl.Location = nextLocation;
            }
        }

        private Point GetNewLocation(int maxSpeed, Control currentControl, Rectangle validSpace)
        {
            int deltaX = rndGEn.Next(-maxSpeed, maxSpeed + 1);
            int deltaY = rndGEn.Next(-maxSpeed, maxSpeed + 1);
            Point currentLocation = currentControl.Location;
            if (currentLocation.X < validSpace.Left)
            {
                deltaX = maxSpeed;
            }
            else if (currentLocation.X > validSpace.Right)
            {
                deltaX = -maxSpeed;
            }

            if (currentLocation.Y < validSpace.Top)
            {
                deltaY = maxSpeed;
            }
            else if (currentLocation.Y > validSpace.Bottom)
            {
                deltaY = -maxSpeed;
            }

            currentLocation.Offset(deltaX, deltaY);
            return currentLocation;
        }

        private Rectangle GetValidSpace(Control currentControl)
        {
            int minX = 0;
            int minY = 0;
            int maxX = ClientSize.Width - currentControl.Width;
            int maxY = ClientSize.Height - currentControl.Height;
            Rectangle validSpace = new Rectangle(minX, minY, maxX - minX, maxY - minY);
            return validSpace;
        }
    }
}
