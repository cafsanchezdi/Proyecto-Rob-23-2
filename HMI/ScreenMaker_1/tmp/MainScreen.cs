//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ABB.Robotics.ScreenMaker.Windows.Forms;
using System;


namespace ScreenMaker_1
{
    
    
    public class MainScreen : ABB.Robotics.ScreenMaker.Windows.Forms.ScreenForm
    {
        
        private ABB.Robotics.Tps.Windows.Forms.Button Pos1;
        
        private ABB.Robotics.Tps.Windows.Forms.Button Pos3;
        
        private ABB.Robotics.Tps.Windows.Forms.Button Pos5;
        
        private ABB.Robotics.Tps.Windows.Forms.Button Pos2;
        
        private ABB.Robotics.Tps.Windows.Forms.Button Pos4;
        
        private ABB.Robotics.Tps.Windows.Forms.Button Pos6;
        
        private ABB.Robotics.Tps.Windows.Forms.Button STOP;
        
        private ABB.Robotics.Tps.Windows.Forms.Button HOME;
        
        private ABB.Robotics.Tps.Windows.Forms.ComboBox Gripper;
        
        private ABB.Robotics.Tps.Windows.Forms.Led Recogiendo;
        
        private ABB.Robotics.Tps.Windows.Forms.Led Dejando;
        
        private ABB.Robotics.Tps.Windows.Forms.Led Movimiento;
        
        private ABB.Robotics.Tps.Windows.Forms.Led Casa;
        
        public MainScreen()
        {
            this.InitializeComponent();
        }
        
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.Pos1 = new ABB.Robotics.Tps.Windows.Forms.Button();
            this.Pos3 = new ABB.Robotics.Tps.Windows.Forms.Button();
            this.Pos5 = new ABB.Robotics.Tps.Windows.Forms.Button();
            this.Pos2 = new ABB.Robotics.Tps.Windows.Forms.Button();
            this.Pos4 = new ABB.Robotics.Tps.Windows.Forms.Button();
            this.Pos6 = new ABB.Robotics.Tps.Windows.Forms.Button();
            this.STOP = new ABB.Robotics.Tps.Windows.Forms.Button();
            this.HOME = new ABB.Robotics.Tps.Windows.Forms.Button();
            this.Gripper = new ABB.Robotics.Tps.Windows.Forms.ComboBox();
            this.Recogiendo = new ABB.Robotics.Tps.Windows.Forms.Led();
            this.Dejando = new ABB.Robotics.Tps.Windows.Forms.Led();
            this.Movimiento = new ABB.Robotics.Tps.Windows.Forms.Led();
            this.Casa = new ABB.Robotics.Tps.Windows.Forms.Led();
            this.SuspendLayout();
            // 
            // Pos1
            // 
            this.Pos1.BackColor = System.Drawing.Color.LimeGreen;
            this.Pos1.Font = ABB.Robotics.Tps.Windows.Forms.TpsFont.Font12b;
            this.Pos1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Pos1.Location = new System.Drawing.Point(35, 35);
            this.Pos1.Name = "Pos1";
            this.Pos1.Size = new System.Drawing.Size(140, 70);
            this.Pos1.Text = "Pos1";
            this.Pos1.TextAlign = ABB.Robotics.Tps.Windows.Forms.ContentAlignmentABB.MiddleCenter;
            this.Pos1.Click += new System.EventHandler(this.Pos1_Click);
            // 
            // Pos3
            // 
            this.Pos3.BackColor = System.Drawing.Color.LimeGreen;
            this.Pos3.Font = ABB.Robotics.Tps.Windows.Forms.TpsFont.Font12b;
            this.Pos3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Pos3.Location = new System.Drawing.Point(35, 111);
            this.Pos3.Name = "Pos3";
            this.Pos3.Size = new System.Drawing.Size(140, 70);
            this.Pos3.Text = "Pos3";
            this.Pos3.TextAlign = ABB.Robotics.Tps.Windows.Forms.ContentAlignmentABB.MiddleCenter;
            this.Pos3.Click += new System.EventHandler(this.Pos3_Click);
            // 
            // Pos5
            // 
            this.Pos5.BackColor = System.Drawing.Color.LimeGreen;
            this.Pos5.Font = ABB.Robotics.Tps.Windows.Forms.TpsFont.Font12b;
            this.Pos5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Pos5.Location = new System.Drawing.Point(35, 187);
            this.Pos5.Name = "Pos5";
            this.Pos5.Size = new System.Drawing.Size(140, 70);
            this.Pos5.Text = "Pos5";
            this.Pos5.TextAlign = ABB.Robotics.Tps.Windows.Forms.ContentAlignmentABB.MiddleCenter;
            this.Pos5.Click += new System.EventHandler(this.Pos5_Click);
            // 
            // Pos2
            // 
            this.Pos2.BackColor = System.Drawing.Color.LimeGreen;
            this.Pos2.Font = ABB.Robotics.Tps.Windows.Forms.TpsFont.Font12b;
            this.Pos2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Pos2.Location = new System.Drawing.Point(181, 35);
            this.Pos2.Name = "Pos2";
            this.Pos2.Size = new System.Drawing.Size(140, 70);
            this.Pos2.Text = "Pos2";
            this.Pos2.TextAlign = ABB.Robotics.Tps.Windows.Forms.ContentAlignmentABB.MiddleCenter;
            this.Pos2.Click += new System.EventHandler(this.Pos2_Click);
            // 
            // Pos4
            // 
            this.Pos4.BackColor = System.Drawing.Color.LimeGreen;
            this.Pos4.Font = ABB.Robotics.Tps.Windows.Forms.TpsFont.Font12b;
            this.Pos4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Pos4.Location = new System.Drawing.Point(181, 111);
            this.Pos4.Name = "Pos4";
            this.Pos4.Size = new System.Drawing.Size(140, 70);
            this.Pos4.Text = "Pos4";
            this.Pos4.TextAlign = ABB.Robotics.Tps.Windows.Forms.ContentAlignmentABB.MiddleCenter;
            this.Pos4.Click += new System.EventHandler(this.Pos4_Click);
            // 
            // Pos6
            // 
            this.Pos6.BackColor = System.Drawing.Color.LimeGreen;
            this.Pos6.Font = ABB.Robotics.Tps.Windows.Forms.TpsFont.Font12b;
            this.Pos6.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Pos6.Location = new System.Drawing.Point(181, 187);
            this.Pos6.Name = "Pos6";
            this.Pos6.Size = new System.Drawing.Size(140, 70);
            this.Pos6.Text = "Pos6";
            this.Pos6.TextAlign = ABB.Robotics.Tps.Windows.Forms.ContentAlignmentABB.MiddleCenter;
            this.Pos6.Click += new System.EventHandler(this.Pos6_Click);
            // 
            // STOP
            // 
            this.STOP.BackColor = System.Drawing.Color.Red;
            this.STOP.Font = ABB.Robotics.Tps.Windows.Forms.TpsFont.Font12b;
            this.STOP.ForeColor = System.Drawing.Color.White;
            this.STOP.Location = new System.Drawing.Point(365, 35);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(247, 222);
            this.STOP.Text = "STOP";
            this.STOP.TextAlign = ABB.Robotics.Tps.Windows.Forms.ContentAlignmentABB.MiddleCenter;
            this.STOP.Click += new System.EventHandler(this.STOP_Click);
            // 
            // HOME
            // 
            this.HOME.BackColor = System.Drawing.Color.White;
            this.HOME.Font = ABB.Robotics.Tps.Windows.Forms.TpsFont.Font12b;
            this.HOME.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HOME.Location = new System.Drawing.Point(365, 317);
            this.HOME.Name = "HOME";
            this.HOME.Size = new System.Drawing.Size(247, 60);
            this.HOME.Text = "HOME";
            this.HOME.TextAlign = ABB.Robotics.Tps.Windows.Forms.ContentAlignmentABB.MiddleCenter;
            this.HOME.Click += new System.EventHandler(this.HOME_Click);
            // 
            // Gripper
            // 
            this.Gripper.BackColor = System.Drawing.Color.Magenta;
            this.Gripper.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", new ABB.Robotics.ScreenMaker.Windows.Forms.SingleBindingSource(new ABB.Robotics.DataBinding.RapidDataObject("T_ROB1", "Module1", "gripperOption")), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.Gripper.DataSource = new ABB.Robotics.ScreenMaker.Windows.Forms.ArrayBindingSource(new ABB.Robotics.DataBinding.RapidDataObject("T_ROB1", "Module1", "gripperOptions"));
            this.Gripper.DisplayMember = "Value";
            this.Gripper.Font = ABB.Robotics.Tps.Windows.Forms.TpsFont.Font12b;
            this.Gripper.ForeColor = System.Drawing.Color.Green;
            this.Gripper.Location = new System.Drawing.Point(35, 317);
            this.Gripper.Name = "Gripper";
            this.Gripper.Size = new System.Drawing.Size(286, 60);
            this.Gripper.ValueMember = "Value";
            // 
            // Recogiendo
            // 
            this.Recogiendo.BackColor = System.Drawing.Color.Black;
            this.Recogiendo.DataBindings.Add(new System.Windows.Forms.Binding("Value", new ABB.Robotics.ScreenMaker.Windows.Forms.SingleBindingSource(new ABB.Robotics.DataBinding.RapidDataObject("T_ROB1", "Module1", "DO_Recoger")), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.Recogiendo.Font = ABB.Robotics.Tps.Windows.Forms.TpsFont.Font12b;
            this.Recogiendo.ForeColor = System.Drawing.Color.White;
            this.Recogiendo.Location = new System.Drawing.Point(35, 263);
            this.Recogiendo.Name = "Recogiendo";
            this.Recogiendo.OffValue = false;
            this.Recogiendo.OnValue = true;
            this.Recogiendo.Size = new System.Drawing.Size(140, 48);
            this.Recogiendo.Text = "Recogiendo";
            // 
            // Dejando
            // 
            this.Dejando.BackColor = System.Drawing.Color.Black;
            this.Dejando.DataBindings.Add(new System.Windows.Forms.Binding("Value", new ABB.Robotics.ScreenMaker.Windows.Forms.SingleBindingSource(new ABB.Robotics.DataBinding.RapidDataObject("T_ROB1", "Module1", "DO_Dejar")), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.Dejando.Font = ABB.Robotics.Tps.Windows.Forms.TpsFont.Font12b;
            this.Dejando.ForeColor = System.Drawing.Color.White;
            this.Dejando.Location = new System.Drawing.Point(181, 263);
            this.Dejando.Name = "Dejando";
            this.Dejando.OffValue = false;
            this.Dejando.OnValue = true;
            this.Dejando.Size = new System.Drawing.Size(140, 48);
            this.Dejando.Text = "Dejando";
            // 
            // Movimiento
            // 
            this.Movimiento.BackColor = System.Drawing.Color.Black;
            this.Movimiento.DataBindings.Add(new System.Windows.Forms.Binding("Value", new ABB.Robotics.ScreenMaker.Windows.Forms.SingleBindingSource(new ABB.Robotics.DataBinding.RapidDataObject("T_ROB1", "Module1", "DO_Mover")), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.Movimiento.Font = ABB.Robotics.Tps.Windows.Forms.TpsFont.Font12b;
            this.Movimiento.ForeColor = System.Drawing.Color.White;
            this.Movimiento.Location = new System.Drawing.Point(365, 263);
            this.Movimiento.Name = "Movimiento";
            this.Movimiento.OffValue = false;
            this.Movimiento.OnValue = true;
            this.Movimiento.Size = new System.Drawing.Size(145, 48);
            this.Movimiento.Text = "Movimiento";
            // 
            // Casa
            // 
            this.Casa.BackColor = System.Drawing.Color.Black;
            this.Casa.DataBindings.Add(new System.Windows.Forms.Binding("Value", new ABB.Robotics.ScreenMaker.Windows.Forms.SingleBindingSource(new ABB.Robotics.DataBinding.RapidDataObject("T_ROB1", "Module1", "DO_Home")), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.Casa.Font = ABB.Robotics.Tps.Windows.Forms.TpsFont.Font12b;
            this.Casa.ForeColor = System.Drawing.Color.White;
            this.Casa.Location = new System.Drawing.Point(521, 263);
            this.Casa.Name = "Casa";
            this.Casa.OffValue = false;
            this.Casa.OnValue = true;
            this.Casa.Size = new System.Drawing.Size(91, 48);
            this.Casa.Text = "Casa";
            // 
            // MainScreen
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Casa);
            this.Controls.Add(this.Movimiento);
            this.Controls.Add(this.Dejando);
            this.Controls.Add(this.Recogiendo);
            this.Controls.Add(this.Gripper);
            this.Controls.Add(this.HOME);
            this.Controls.Add(this.STOP);
            this.Controls.Add(this.Pos6);
            this.Controls.Add(this.Pos4);
            this.Controls.Add(this.Pos2);
            this.Controls.Add(this.Pos5);
            this.Controls.Add(this.Pos3);
            this.Controls.Add(this.Pos1);
            this.Controls.SetChildIndex(this.Pos1, 0);
            this.Controls.SetChildIndex(this.Pos3, 0);
            this.Controls.SetChildIndex(this.Pos5, 0);
            this.Controls.SetChildIndex(this.Pos2, 0);
            this.Controls.SetChildIndex(this.Pos4, 0);
            this.Controls.SetChildIndex(this.Pos6, 0);
            this.Controls.SetChildIndex(this.STOP, 0);
            this.Controls.SetChildIndex(this.HOME, 0);
            this.Controls.SetChildIndex(this.Gripper, 0);
            this.Controls.SetChildIndex(this.Recogiendo, 0);
            this.Controls.SetChildIndex(this.Dejando, 0);
            this.Controls.SetChildIndex(this.Movimiento, 0);
            this.Controls.SetChildIndex(this.Casa, 0);
            this.ResumeLayout(false);
        }
        #endregion
        
        private void Pos1_Click(object sender, System.EventArgs e)
        {
            try
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, this.Pos1_Click_Ack, "¿Todo Listo?", "Warning", System.Windows.Forms.MessageBoxIcon.Exclamation, System.Windows.Forms.MessageBoxButtons.YesNo);
            }
            catch (System.Exception ex)
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in Pos1_Click", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
            }
        }
        
        private void Pos2_Click(object sender, System.EventArgs e)
        {
            try
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, this.Pos2_Click_Ack, "¿Todo Listo?", "Warning", System.Windows.Forms.MessageBoxIcon.Exclamation, System.Windows.Forms.MessageBoxButtons.YesNo);
            }
            catch (System.Exception ex)
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in Pos2_Click", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
            }
        }
        
        private void Pos1_Click_Ack(object sender, ABB.Robotics.Tps.Windows.Forms.MessageBoxEventArgs e)
        {
            if ((e.DialogResult == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    // Calling RapidDataWrite
                    ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_0 = this.ScreenServices.ApplicationVariables["POS1"];
                    ABB.Robotics.ScreenMaker.Windows.Forms.DataManager.GetRapidData(this, "RAPID/T_ROB1/Module1/posControl").Value = ((ABB.Robotics.Controllers.RapidDomain.IRapidData)(write_0.Value));
                }
                catch (System.Exception ex)
                {
                    ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in Pos1_Click_Ack", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
        }
        
        private void Pos2_Click_Ack(object sender, ABB.Robotics.Tps.Windows.Forms.MessageBoxEventArgs e)
        {
            if ((e.DialogResult == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    // Calling RapidDataWrite
                    ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_0 = this.ScreenServices.ApplicationVariables["POS2"];
                    ABB.Robotics.ScreenMaker.Windows.Forms.DataManager.GetRapidData(this, "RAPID/T_ROB1/Module1/posControl").Value = ((ABB.Robotics.Controllers.RapidDomain.IRapidData)(write_0.Value));
                }
                catch (System.Exception ex)
                {
                    ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in Pos2_Click_Ack", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
        }
        
        private void Pos3_Click(object sender, System.EventArgs e)
        {
            try
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, this.Pos3_Click_Ack, "¿Todo Listo?", "Warning", System.Windows.Forms.MessageBoxIcon.Exclamation, System.Windows.Forms.MessageBoxButtons.YesNo);
            }
            catch (System.Exception ex)
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in Pos3_Click", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
            }
        }
        
        private void Pos3_Click_Ack(object sender, ABB.Robotics.Tps.Windows.Forms.MessageBoxEventArgs e)
        {
            if ((e.DialogResult == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    // Calling RapidDataWrite
                    ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_0 = this.ScreenServices.ApplicationVariables["POS3"];
                    ABB.Robotics.ScreenMaker.Windows.Forms.DataManager.GetRapidData(this, "RAPID/T_ROB1/Module1/posControl").Value = ((ABB.Robotics.Controllers.RapidDomain.IRapidData)(write_0.Value));
                }
                catch (System.Exception ex)
                {
                    ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in Pos3_Click_Ack", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
        }
        
        private void Pos4_Click(object sender, System.EventArgs e)
        {
            try
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, this.Pos4_Click_Ack, "¿Todo Listo?", "Warning", System.Windows.Forms.MessageBoxIcon.Exclamation, System.Windows.Forms.MessageBoxButtons.YesNo);
            }
            catch (System.Exception ex)
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in Pos4_Click", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
            }
        }
        
        private void Pos4_Click_Ack(object sender, ABB.Robotics.Tps.Windows.Forms.MessageBoxEventArgs e)
        {
            if ((e.DialogResult == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    // Calling RapidDataWrite
                    ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_0 = this.ScreenServices.ApplicationVariables["POS4"];
                    ABB.Robotics.ScreenMaker.Windows.Forms.DataManager.GetRapidData(this, "RAPID/T_ROB1/Module1/posControl").Value = ((ABB.Robotics.Controllers.RapidDomain.IRapidData)(write_0.Value));
                }
                catch (System.Exception ex)
                {
                    ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in Pos4_Click_Ack", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
        }
        
        private void Pos5_Click(object sender, System.EventArgs e)
        {
            try
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, this.Pos5_Click_Ack, "¿Todo Listo?", "Warning", System.Windows.Forms.MessageBoxIcon.Exclamation, System.Windows.Forms.MessageBoxButtons.YesNo);
            }
            catch (System.Exception ex)
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in Pos5_Click", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
            }
        }
        
        private void Pos5_Click_Ack(object sender, ABB.Robotics.Tps.Windows.Forms.MessageBoxEventArgs e)
        {
            if ((e.DialogResult == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    // Calling RapidDataWrite
                    ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_0 = this.ScreenServices.ApplicationVariables["POS5"];
                    ABB.Robotics.ScreenMaker.Windows.Forms.DataManager.GetRapidData(this, "RAPID/T_ROB1/Module1/posControl").Value = ((ABB.Robotics.Controllers.RapidDomain.IRapidData)(write_0.Value));
                }
                catch (System.Exception ex)
                {
                    ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in Pos5_Click_Ack", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
        }
        
        private void Pos6_Click(object sender, System.EventArgs e)
        {
            try
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, this.Pos6_Click_Ack, "¿Todo Listo?", "Warning", System.Windows.Forms.MessageBoxIcon.Exclamation, System.Windows.Forms.MessageBoxButtons.YesNo);
            }
            catch (System.Exception ex)
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in Pos6_Click", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
            }
        }
        
        private void Pos6_Click_Ack(object sender, ABB.Robotics.Tps.Windows.Forms.MessageBoxEventArgs e)
        {
            if ((e.DialogResult == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    // Calling RapidDataWrite
                    ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_0 = this.ScreenServices.ApplicationVariables["POS6"];
                    ABB.Robotics.ScreenMaker.Windows.Forms.DataManager.GetRapidData(this, "RAPID/T_ROB1/Module1/posControl").Value = ((ABB.Robotics.Controllers.RapidDomain.IRapidData)(write_0.Value));
                }
                catch (System.Exception ex)
                {
                    ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in Pos6_Click_Ack", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
        }
        
        private void STOP_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Calling RapidDataWrite
                ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_0 = this.ScreenServices.ApplicationVariables["Verdadero"];
                ABB.Robotics.ScreenMaker.Windows.Forms.DataManager.GetRapidData(this, "RAPID/T_ROB1/Module1/DO_STOP").Value = ((ABB.Robotics.Controllers.RapidDomain.IRapidData)(write_0.Value));
            }
            catch (System.Exception ex)
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in STOP_Click", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
            }
        }
        
        private void HOME_Click(object sender, System.EventArgs e)
        {
            try
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, this.HOME_Click_Ack, "¿Ir a casita?", "Warning", System.Windows.Forms.MessageBoxIcon.Exclamation, System.Windows.Forms.MessageBoxButtons.YesNo);
            }
            catch (System.Exception ex)
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in HOME_Click", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
            }
        }
        
        private void HOME_Click_Ack(object sender, ABB.Robotics.Tps.Windows.Forms.MessageBoxEventArgs e)
        {
            if ((e.DialogResult == System.Windows.Forms.DialogResult.Yes))
            {
                try
                {
                    // Calling RapidDataWrite
                    ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_0 = this.ScreenServices.ApplicationVariables["Verdadero"];
                    ABB.Robotics.ScreenMaker.Windows.Forms.DataManager.GetRapidData(this, "RAPID/T_ROB1/Module1/DO_IrHome").Value = ((ABB.Robotics.Controllers.RapidDomain.IRapidData)(write_0.Value));
                }
                catch (System.Exception ex)
                {
                    ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in HOME_Click_Ack", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
        }
        
        #region Protected Methods
        protected override void OnInstall(ABB.Robotics.ScreenMaker.Base.IScreenServices services)
        {
            if ((services.ApplicationVariables.Count == 0))
            {
                // 
                // POS1
                // 
                ABB.Robotics.ScreenMaker.Base.ApplicationVariable POS1 = new ABB.Robotics.ScreenMaker.Base.ApplicationVariable("POS1", "1", typeof(ABB.Robotics.Controllers.RapidDomain.Num));
                // 
                // POS2
                // 
                ABB.Robotics.ScreenMaker.Base.ApplicationVariable POS2 = new ABB.Robotics.ScreenMaker.Base.ApplicationVariable("POS2", "2", typeof(ABB.Robotics.Controllers.RapidDomain.Num));
                // 
                // POS3
                // 
                ABB.Robotics.ScreenMaker.Base.ApplicationVariable POS3 = new ABB.Robotics.ScreenMaker.Base.ApplicationVariable("POS3", "3", typeof(ABB.Robotics.Controllers.RapidDomain.Num));
                // 
                // POS4
                // 
                ABB.Robotics.ScreenMaker.Base.ApplicationVariable POS4 = new ABB.Robotics.ScreenMaker.Base.ApplicationVariable("POS4", "4", typeof(ABB.Robotics.Controllers.RapidDomain.Num));
                // 
                // POS5
                // 
                ABB.Robotics.ScreenMaker.Base.ApplicationVariable POS5 = new ABB.Robotics.ScreenMaker.Base.ApplicationVariable("POS5", "5", typeof(ABB.Robotics.Controllers.RapidDomain.Num));
                // 
                // POS6
                // 
                ABB.Robotics.ScreenMaker.Base.ApplicationVariable POS6 = new ABB.Robotics.ScreenMaker.Base.ApplicationVariable("POS6", "6", typeof(ABB.Robotics.Controllers.RapidDomain.Num));
                // 
                // Falso
                // 
                ABB.Robotics.ScreenMaker.Base.ApplicationVariable Falso = new ABB.Robotics.ScreenMaker.Base.ApplicationVariable("Falso", "False", typeof(ABB.Robotics.Controllers.RapidDomain.Bool));
                // 
                // Verdadero
                // 
                ABB.Robotics.ScreenMaker.Base.ApplicationVariable Verdadero = new ABB.Robotics.ScreenMaker.Base.ApplicationVariable("Verdadero", "True", typeof(ABB.Robotics.Controllers.RapidDomain.Bool));
                // 
                // Store variables
                // 
                services.ApplicationVariables.Add("POS1", POS1);
                services.ApplicationVariables.Add("POS2", POS2);
                services.ApplicationVariables.Add("POS3", POS3);
                services.ApplicationVariables.Add("POS4", POS4);
                services.ApplicationVariables.Add("POS5", POS5);
                services.ApplicationVariables.Add("POS6", POS6);
                services.ApplicationVariables.Add("Falso", Falso);
                services.ApplicationVariables.Add("Verdadero", Verdadero);
            }
            base.OnInstall(services);
        }
        #endregion
    }
}
