
namespace QuickRAT_Host
{
    partial class ScreenView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenView));
            this.screenimage = new System.Windows.Forms.PictureBox();
            this.enablemouse = new Guna.UI2.WinForms.Guna2CheckBox();
            this.enablekeyboard = new Guna.UI2.WinForms.Guna2CheckBox();
            this.monitorselector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.togglescreenview = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.screenimage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenimage
            // 
            this.screenimage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.screenimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenimage.Image = ((System.Drawing.Image)(resources.GetObject("screenimage.Image")));
            this.screenimage.Location = new System.Drawing.Point(150, 82);
            this.screenimage.Name = "screenimage";
            this.screenimage.Size = new System.Drawing.Size(700, 394);
            this.screenimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.screenimage.TabIndex = 0;
            this.screenimage.TabStop = false;
            // 
            // enablemouse
            // 
            this.enablemouse.Animated = true;
            this.enablemouse.AutoSize = true;
            this.enablemouse.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enablemouse.CheckedState.BorderRadius = 0;
            this.enablemouse.CheckedState.BorderThickness = 0;
            this.enablemouse.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enablemouse.CheckMarkColor = System.Drawing.Color.Lime;
            this.enablemouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enablemouse.ForeColor = System.Drawing.Color.White;
            this.enablemouse.Location = new System.Drawing.Point(870, 80);
            this.enablemouse.Name = "enablemouse";
            this.enablemouse.Size = new System.Drawing.Size(69, 21);
            this.enablemouse.TabIndex = 1;
            this.enablemouse.Text = "Mouse";
            this.enablemouse.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.enablemouse.UncheckedState.BorderRadius = 0;
            this.enablemouse.UncheckedState.BorderThickness = 0;
            this.enablemouse.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // enablekeyboard
            // 
            this.enablekeyboard.Animated = true;
            this.enablekeyboard.AutoSize = true;
            this.enablekeyboard.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enablekeyboard.CheckedState.BorderRadius = 0;
            this.enablekeyboard.CheckedState.BorderThickness = 0;
            this.enablekeyboard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.enablekeyboard.CheckMarkColor = System.Drawing.Color.Lime;
            this.enablekeyboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enablekeyboard.ForeColor = System.Drawing.Color.White;
            this.enablekeyboard.Location = new System.Drawing.Point(870, 100);
            this.enablekeyboard.Name = "enablekeyboard";
            this.enablekeyboard.Size = new System.Drawing.Size(88, 21);
            this.enablekeyboard.TabIndex = 2;
            this.enablekeyboard.Text = "Keyboard";
            this.enablekeyboard.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.enablekeyboard.UncheckedState.BorderRadius = 0;
            this.enablekeyboard.UncheckedState.BorderThickness = 0;
            this.enablekeyboard.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // monitorselector
            // 
            this.monitorselector.BackColor = System.Drawing.Color.Transparent;
            this.monitorselector.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.monitorselector.BorderRadius = 5;
            this.monitorselector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.monitorselector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monitorselector.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.monitorselector.FocusedColor = System.Drawing.Color.Aqua;
            this.monitorselector.FocusedState.BorderColor = System.Drawing.Color.Aqua;
            this.monitorselector.FocusedState.Parent = this.monitorselector;
            this.monitorselector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.monitorselector.ForeColor = System.Drawing.Color.White;
            this.monitorselector.HoverState.BorderColor = System.Drawing.Color.Aqua;
            this.monitorselector.HoverState.Parent = this.monitorselector;
            this.monitorselector.ItemHeight = 30;
            this.monitorselector.ItemsAppearance.Parent = this.monitorselector;
            this.monitorselector.Location = new System.Drawing.Point(13, 80);
            this.monitorselector.Name = "monitorselector";
            this.monitorselector.ShadowDecoration.Parent = this.monitorselector;
            this.monitorselector.Size = new System.Drawing.Size(120, 36);
            this.monitorselector.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(424, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Screen View";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 40);
            this.panel1.TabIndex = 19;
            // 
            // togglescreenview
            // 
            this.togglescreenview.Animated = true;
            this.togglescreenview.BackColor = System.Drawing.Color.Transparent;
            this.togglescreenview.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.togglescreenview.CheckedState.BorderRadius = 8;
            this.togglescreenview.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.togglescreenview.CheckedState.InnerBorderColor = System.Drawing.Color.Lime;
            this.togglescreenview.CheckedState.InnerColor = System.Drawing.Color.Lime;
            this.togglescreenview.CheckedState.Parent = this.togglescreenview;
            this.togglescreenview.Location = new System.Drawing.Point(475, 48);
            this.togglescreenview.Margin = new System.Windows.Forms.Padding(0);
            this.togglescreenview.Name = "togglescreenview";
            this.togglescreenview.ShadowDecoration.Parent = this.togglescreenview;
            this.togglescreenview.Size = new System.Drawing.Size(50, 25);
            this.togglescreenview.TabIndex = 20;
            this.togglescreenview.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.togglescreenview.UncheckedState.BorderRadius = 8;
            this.togglescreenview.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.togglescreenview.UncheckedState.InnerBorderColor = System.Drawing.Color.Red;
            this.togglescreenview.UncheckedState.InnerColor = System.Drawing.Color.Red;
            this.togglescreenview.UncheckedState.Parent = this.togglescreenview;
            this.togglescreenview.UseTransparentBackground = true;
            // 
            // ScreenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.togglescreenview);
            this.Controls.Add(this.monitorselector);
            this.Controls.Add(this.enablekeyboard);
            this.Controls.Add(this.enablemouse);
            this.Controls.Add(this.screenimage);
            this.Controls.Add(this.panel1);
            this.Name = "ScreenView";
            this.Size = new System.Drawing.Size(1000, 490);
            ((System.ComponentModel.ISupportInitialize)(this.screenimage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox screenimage;
        private Guna.UI2.WinForms.Guna2CheckBox enablemouse;
        private Guna.UI2.WinForms.Guna2CheckBox enablekeyboard;
        private Guna.UI2.WinForms.Guna2ComboBox monitorselector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch togglescreenview;
    }
}
