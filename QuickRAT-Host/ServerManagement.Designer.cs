
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.selectclientbtn = new Guna.UI2.WinForms.Guna2Button();
            this.svstatuslabel = new System.Windows.Forms.Label();
            this.statuslabel = new System.Windows.Forms.Label();
            this.toggleserver = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.dragpanel = new System.Windows.Forms.Panel();
            this.titlelabel = new System.Windows.Forms.Label();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.av = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dragpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
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
            this.svstatuslabel.ForeColor = System.Drawing.Color.Red;
            this.svstatuslabel.Location = new System.Drawing.Point(504, 86);
            this.svstatuslabel.Name = "svstatuslabel";
            this.svstatuslabel.Size = new System.Drawing.Size(55, 20);
            this.svstatuslabel.TabIndex = 11;
            this.svstatuslabel.Text = "Offline";
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
            // guna2DataGridView2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.time,
            this.av});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView2.EnableHeadersVisualStyles = false;
            this.guna2DataGridView2.GridColor = System.Drawing.Color.Black;
            this.guna2DataGridView2.Location = new System.Drawing.Point(246, 109);
            this.guna2DataGridView2.Name = "guna2DataGridView2";
            this.guna2DataGridView2.RowHeadersVisible = false;
            this.guna2DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView2.Size = new System.Drawing.Size(500, 300);
            this.guna2DataGridView2.TabIndex = 17;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridView2.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            // 
            // av
            // 
            this.av.HeaderText = "AV";
            this.av.Name = "av";
            // 
            // ServerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.guna2DataGridView2);
            this.Controls.Add(this.dragpanel);
            this.Controls.Add(this.toggleserver);
            this.Controls.Add(this.selectclientbtn);
            this.Controls.Add(this.svstatuslabel);
            this.Controls.Add(this.statuslabel);
            this.Name = "ServerManagement";
            this.Size = new System.Drawing.Size(1000, 490);
            this.dragpanel.ResumeLayout(false);
            this.dragpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn av;
    }
}
