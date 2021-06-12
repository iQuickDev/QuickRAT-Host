
namespace QuickRAT_Host
{
    partial class ServerManagement
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
            this.selectclientbtn = new Guna.UI2.WinForms.Guna2Button();
            this.svstatuslabel = new System.Windows.Forms.Label();
            this.statuslabel = new System.Windows.Forms.Label();
            this.toggleserver = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.dragpanel = new System.Windows.Forms.Panel();
            this.titlelabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pcname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.localtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.antivirus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dragpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectclientbtn
            // 
            this.selectclientbtn.Animated = true;
            this.selectclientbtn.AnimatedGIF = true;
            this.selectclientbtn.BorderRadius = 5;
            this.selectclientbtn.CheckedState.Parent = this.selectclientbtn;
            this.selectclientbtn.CustomImages.Parent = this.selectclientbtn;
            this.selectclientbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.selectclientbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.selectclientbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.selectclientbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.selectclientbtn.DisabledState.Parent = this.selectclientbtn;
            this.selectclientbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.selectclientbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectclientbtn.ForeColor = System.Drawing.Color.White;
            this.selectclientbtn.HoverState.Parent = this.selectclientbtn;
            this.selectclientbtn.Location = new System.Drawing.Point(410, 425);
            this.selectclientbtn.Name = "selectclientbtn";
            this.selectclientbtn.PressedDepth = 0;
            this.selectclientbtn.ShadowDecoration.Parent = this.selectclientbtn;
            this.selectclientbtn.Size = new System.Drawing.Size(180, 45);
            this.selectclientbtn.TabIndex = 13;
            this.selectclientbtn.Text = "Manage Selected Client";
            // 
            // svstatuslabel
            // 
            this.svstatuslabel.AutoSize = true;
            this.svstatuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.svstatuslabel.ForeColor = System.Drawing.Color.White;
            this.svstatuslabel.Location = new System.Drawing.Point(504, 86);
            this.svstatuslabel.Name = "svstatuslabel";
            this.svstatuslabel.Size = new System.Drawing.Size(71, 20);
            this.svstatuslabel.TabIndex = 11;
            this.svstatuslabel.Text = "svStatus";
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.statuslabel.ForeColor = System.Drawing.Color.White;
            this.statuslabel.Location = new System.Drawing.Point(425, 86);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(83, 20);
            this.statuslabel.TabIndex = 10;
            this.statuslabel.Text = "STATUS:";
            // 
            // toggleserver
            // 
            this.toggleserver.Animated = true;
            this.toggleserver.BackColor = System.Drawing.Color.Transparent;
            this.toggleserver.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toggleserver.CheckedState.BorderRadius = 8;
            this.toggleserver.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toggleserver.CheckedState.InnerBorderColor = System.Drawing.Color.Lime;
            this.toggleserver.CheckedState.InnerColor = System.Drawing.Color.Lime;
            this.toggleserver.CheckedState.Parent = this.toggleserver;
            this.toggleserver.Location = new System.Drawing.Point(475, 52);
            this.toggleserver.Margin = new System.Windows.Forms.Padding(0);
            this.toggleserver.Name = "toggleserver";
            this.toggleserver.ShadowDecoration.Parent = this.toggleserver;
            this.toggleserver.Size = new System.Drawing.Size(50, 25);
            this.toggleserver.TabIndex = 14;
            this.toggleserver.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toggleserver.UncheckedState.BorderRadius = 8;
            this.toggleserver.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toggleserver.UncheckedState.InnerBorderColor = System.Drawing.Color.Red;
            this.toggleserver.UncheckedState.InnerColor = System.Drawing.Color.Red;
            this.toggleserver.UncheckedState.Parent = this.toggleserver;
            this.toggleserver.UseTransparentBackground = true;
            // 
            // dragpanel
            // 
            this.dragpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dragpanel.Controls.Add(this.titlelabel);
            this.dragpanel.Location = new System.Drawing.Point(0, 0);
            this.dragpanel.Name = "dragpanel";
            this.dragpanel.Size = new System.Drawing.Size(1000, 40);
            this.dragpanel.TabIndex = 15;
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.titlelabel.ForeColor = System.Drawing.Color.White;
            this.titlelabel.Location = new System.Drawing.Point(377, 2);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(246, 32);
            this.titlelabel.TabIndex = 16;
            this.titlelabel.Text = "Server Management";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.pcname,
            this.localtime,
            this.antivirus});
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(294, 109);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(412, 300);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // pcname
            // 
            this.pcname.Text = "Name";
            this.pcname.Width = 113;
            // 
            // localtime
            // 
            this.localtime.Text = "Time";
            this.localtime.Width = 123;
            // 
            // antivirus
            // 
            this.antivirus.Text = "AV";
            this.antivirus.Width = 116;
            // 
            // ServerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dragpanel);
            this.Controls.Add(this.toggleserver);
            this.Controls.Add(this.selectclientbtn);
            this.Controls.Add(this.svstatuslabel);
            this.Controls.Add(this.statuslabel);
            this.Name = "ServerManagement";
            this.Size = new System.Drawing.Size(1000, 490);
            this.dragpanel.ResumeLayout(false);
            this.dragpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button selectclientbtn;
        private System.Windows.Forms.Label svstatuslabel;
        private System.Windows.Forms.Label statuslabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleserver;
        private System.Windows.Forms.Panel dragpanel;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader pcname;
        private System.Windows.Forms.ColumnHeader localtime;
        private System.Windows.Forms.ColumnHeader antivirus;
    }
}
