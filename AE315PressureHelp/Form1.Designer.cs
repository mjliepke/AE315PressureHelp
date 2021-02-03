namespace AE315PressureHelp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.p_inf_in_HGTextbox = new System.Windows.Forms.TextBox();
            this.p_inf_in_HgLabel = new System.Windows.Forms.Label();
            this.T_inf_FLabel = new System.Windows.Forms.Label();
            this.T_inf_FTextBox = new System.Windows.Forms.TextBox();
            this.v_infLabel = new System.Windows.Forms.Label();
            this.v_infTextBox = new System.Windows.Forms.TextBox();
            this.p_inf_PaLabel = new System.Windows.Forms.Label();
            this.p_inf_PaTextbox = new System.Windows.Forms.TextBox();
            this.T_inf_KLabel = new System.Windows.Forms.Label();
            this.T_inf_KTextBox = new System.Windows.Forms.TextBox();
            this.q_in_h20Label = new System.Windows.Forms.Label();
            this.q_inf_in_H20TextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.rhoLabel = new System.Windows.Forms.Label();
            this.rho_SITextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // p_inf_in_HGTextbox
            // 
            this.p_inf_in_HGTextbox.Location = new System.Drawing.Point(12, 25);
            this.p_inf_in_HGTextbox.Name = "p_inf_in_HGTextbox";
            this.p_inf_in_HGTextbox.Size = new System.Drawing.Size(100, 20);
            this.p_inf_in_HGTextbox.TabIndex = 0;
            this.p_inf_in_HGTextbox.TextChanged += new System.EventHandler(this.p_inf_in_HGTextbox_TextChanged);
            this.p_inf_in_HGTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoCharacters);
            // 
            // p_inf_in_HgLabel
            // 
            this.p_inf_in_HgLabel.AutoSize = true;
            this.p_inf_in_HgLabel.Location = new System.Drawing.Point(38, 9);
            this.p_inf_in_HgLabel.Name = "p_inf_in_HgLabel";
            this.p_inf_in_HgLabel.Size = new System.Drawing.Size(66, 13);
            this.p_inf_in_HgLabel.TabIndex = 1;
            this.p_inf_in_HgLabel.Text = "p_inf [in HG]";
            // 
            // T_inf_FLabel
            // 
            this.T_inf_FLabel.AutoSize = true;
            this.T_inf_FLabel.Location = new System.Drawing.Point(38, 48);
            this.T_inf_FLabel.Name = "T_inf_FLabel";
            this.T_inf_FLabel.Size = new System.Drawing.Size(46, 13);
            this.T_inf_FLabel.TabIndex = 3;
            this.T_inf_FLabel.Text = "T_inf [F]";
            // 
            // T_inf_FTextBox
            // 
            this.T_inf_FTextBox.Location = new System.Drawing.Point(12, 64);
            this.T_inf_FTextBox.Name = "T_inf_FTextBox";
            this.T_inf_FTextBox.Size = new System.Drawing.Size(100, 20);
            this.T_inf_FTextBox.TabIndex = 2;
            this.T_inf_FTextBox.TextChanged += new System.EventHandler(this.T_inf_FTextBox_TextChanged);
            this.T_inf_FTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoCharacters);
            // 
            // v_infLabel
            // 
            this.v_infLabel.AutoSize = true;
            this.v_infLabel.Location = new System.Drawing.Point(38, 89);
            this.v_infLabel.Name = "v_infLabel";
            this.v_infLabel.Size = new System.Drawing.Size(40, 13);
            this.v_infLabel.TabIndex = 5;
            this.v_infLabel.Text = "v [m/s]";
            // 
            // v_infTextBox
            // 
            this.v_infTextBox.Location = new System.Drawing.Point(12, 105);
            this.v_infTextBox.Name = "v_infTextBox";
            this.v_infTextBox.Size = new System.Drawing.Size(100, 20);
            this.v_infTextBox.TabIndex = 4;
            this.v_infTextBox.TextChanged += new System.EventHandler(this.UpdateDynamicPressure);
            this.v_infTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoCharacters);
            // 
            // p_inf_PaLabel
            // 
            this.p_inf_PaLabel.AutoSize = true;
            this.p_inf_PaLabel.Location = new System.Drawing.Point(166, 9);
            this.p_inf_PaLabel.Name = "p_inf_PaLabel";
            this.p_inf_PaLabel.Size = new System.Drawing.Size(52, 13);
            this.p_inf_PaLabel.TabIndex = 7;
            this.p_inf_PaLabel.Text = "p_inf [Pa]";
            // 
            // p_inf_PaTextbox
            // 
            this.p_inf_PaTextbox.Enabled = false;
            this.p_inf_PaTextbox.Location = new System.Drawing.Point(140, 25);
            this.p_inf_PaTextbox.Name = "p_inf_PaTextbox";
            this.p_inf_PaTextbox.Size = new System.Drawing.Size(100, 20);
            this.p_inf_PaTextbox.TabIndex = 6;
            this.p_inf_PaTextbox.TextChanged += new System.EventHandler(this.UpdateDensity);
            // 
            // T_inf_KLabel
            // 
            this.T_inf_KLabel.AutoSize = true;
            this.T_inf_KLabel.Location = new System.Drawing.Point(166, 48);
            this.T_inf_KLabel.Name = "T_inf_KLabel";
            this.T_inf_KLabel.Size = new System.Drawing.Size(47, 13);
            this.T_inf_KLabel.TabIndex = 9;
            this.T_inf_KLabel.Text = "T_inf [K]";
            // 
            // T_inf_KTextBox
            // 
            this.T_inf_KTextBox.Enabled = false;
            this.T_inf_KTextBox.Location = new System.Drawing.Point(140, 64);
            this.T_inf_KTextBox.Name = "T_inf_KTextBox";
            this.T_inf_KTextBox.Size = new System.Drawing.Size(100, 20);
            this.T_inf_KTextBox.TabIndex = 8;
            this.T_inf_KTextBox.TextChanged += new System.EventHandler(this.UpdateDensity);
            // 
            // q_in_h20Label
            // 
            this.q_in_h20Label.AutoSize = true;
            this.q_in_h20Label.Location = new System.Drawing.Point(163, 127);
            this.q_in_h20Label.Name = "q_in_h20Label";
            this.q_in_h20Label.Size = new System.Drawing.Size(55, 13);
            this.q_in_h20Label.TabIndex = 11;
            this.q_in_h20Label.Text = "q [in H2O]";
            // 
            // q_inf_in_H20TextBox
            // 
            this.q_inf_in_H20TextBox.Enabled = false;
            this.q_inf_in_H20TextBox.Location = new System.Drawing.Point(137, 143);
            this.q_inf_in_H20TextBox.Name = "q_inf_in_H20TextBox";
            this.q_inf_in_H20TextBox.Size = new System.Drawing.Size(100, 20);
            this.q_inf_in_H20TextBox.TabIndex = 10;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(17, 143);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(95, 20);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "Do Mafs";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // rhoLabel
            // 
            this.rhoLabel.AutoSize = true;
            this.rhoLabel.Location = new System.Drawing.Point(163, 89);
            this.rhoLabel.Name = "rhoLabel";
            this.rhoLabel.Size = new System.Drawing.Size(68, 13);
            this.rhoLabel.TabIndex = 14;
            this.rhoLabel.Text = "rho [kg/m^3]";
            // 
            // rho_SITextbox
            // 
            this.rho_SITextbox.Enabled = false;
            this.rho_SITextbox.Location = new System.Drawing.Point(137, 105);
            this.rho_SITextbox.Name = "rho_SITextbox";
            this.rho_SITextbox.Size = new System.Drawing.Size(100, 20);
            this.rho_SITextbox.TabIndex = 13;
            this.rho_SITextbox.TextChanged += new System.EventHandler(this.UpdateDynamicPressure);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 196);
            this.Controls.Add(this.rhoLabel);
            this.Controls.Add(this.rho_SITextbox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.q_in_h20Label);
            this.Controls.Add(this.q_inf_in_H20TextBox);
            this.Controls.Add(this.T_inf_KLabel);
            this.Controls.Add(this.T_inf_KTextBox);
            this.Controls.Add(this.p_inf_PaLabel);
            this.Controls.Add(this.p_inf_PaTextbox);
            this.Controls.Add(this.v_infLabel);
            this.Controls.Add(this.v_infTextBox);
            this.Controls.Add(this.T_inf_FLabel);
            this.Controls.Add(this.T_inf_FTextBox);
            this.Controls.Add(this.p_inf_in_HgLabel);
            this.Controls.Add(this.p_inf_in_HGTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox p_inf_in_HGTextbox;
        private System.Windows.Forms.Label p_inf_in_HgLabel;
        private System.Windows.Forms.Label T_inf_FLabel;
        private System.Windows.Forms.TextBox T_inf_FTextBox;
        private System.Windows.Forms.Label v_infLabel;
        private System.Windows.Forms.TextBox v_infTextBox;
        private System.Windows.Forms.Label p_inf_PaLabel;
        private System.Windows.Forms.TextBox p_inf_PaTextbox;
        private System.Windows.Forms.Label T_inf_KLabel;
        private System.Windows.Forms.TextBox T_inf_KTextBox;
        private System.Windows.Forms.Label q_in_h20Label;
        private System.Windows.Forms.TextBox q_inf_in_H20TextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label rhoLabel;
        private System.Windows.Forms.TextBox rho_SITextbox;
    }
}

