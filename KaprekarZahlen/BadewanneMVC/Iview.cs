using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BadewanneMVC
    {
        class Iview : IBadewanneView
        {
            public event EventHandler ViewChanged;

            public void ControllerInput(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            public void ModelChanged(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }



            public void Zustandwechsel(object sender, EventArgs e)
            {

                string voll = "Zur Kenntnis: die Badewanne ist schon voll";
                string ueber = "Huee: schließe sofort den Hahn ab";
                string halbvoll = "50% sind ereicht";
                string vorsicht = "Die Badewanne ist auf mehr als 90% gefüllt";
                string leer = "Badewanne ist noch leer. Mach doch was!";
                int fstand = ((IBadewanneModel)sender).Fuellstand;
                int volume = ((IBadewanneModel)sender).Kapazitaet;

                if (fstand > 0 && fstand < 270)
                {
                    do
                    {
                        MessageBox.Show("Badewanne enthält " + (fstand) + " Liter");

                    }
                    while (fstand == 270 && fstand == 0);

                }
                if (((IBadewanneModel)sender).Voll)
                    MessageBox.Show(voll);
                if (fstand > 270 && 300 < fstand)
                    MessageBox.Show(vorsicht);
                if (fstand == 150)
                    MessageBox.Show(halbvoll);
                if (fstand == 0)
                    MessageBox.Show(leer);
                if (fstand > 300)
                    MessageBox.Show(ueber);
                
                


            }


             // Darstellung der Füllung
            private void DrawImagePointF(PaintEventArgs e)
            {

                // Create image.
                Image newImage = Image.FromFile("SampImag.jpg");

                // Create point for upper-left corner of image.
                PointF ulCorner = new PointF(100.0F, 100.0F);

                // Draw image to screen.
                e.Graphics.DrawImage(newImage, ulCorner);
            }

        // Timer definieren

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
            static int alarmCounter = 1;
            static bool exitFlag = false;

            // This is the method to run when the timer is raised.
            private static void TimerEventProcessor(Object myObject,
                                                    EventArgs myEventArgs)
            {
                myTimer.Stop();

                // Displays a message box asking whether to continue running the timer.
                if (MessageBox.Show("Fortfahren?", "Kapazität: " + alarmCounter,
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Restarts the timer and increments the counter.
                    alarmCounter += 1;
                    myTimer.Enabled = true;
                }
                else
                {
                    // Stops the timer.
                    exitFlag = true;
                }

            }
        }
    
    }

