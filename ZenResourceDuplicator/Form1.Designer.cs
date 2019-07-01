namespace ZenResourceDuplicator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.debugInstructionsLabel = new System.Windows.Forms.Label();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.txtRID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewTag = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCurrentTags = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRName = new System.Windows.Forms.Label();
            this.cbOwners = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // debugInstructionsLabel
            // 
            this.debugInstructionsLabel.AutoSize = true;
            this.debugInstructionsLabel.Location = new System.Drawing.Point(17, 35);
            this.debugInstructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.debugInstructionsLabel.Name = "debugInstructionsLabel";
            this.debugInstructionsLabel.Size = new System.Drawing.Size(432, 13);
            this.debugInstructionsLabel.TabIndex = 1;
            this.debugInstructionsLabel.Text = "You\'ll need the Zen ID ie 1972983959 in https://app.futuresimple.com/leads/197298" +
    "3959";
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(94, 9);
            this.helloWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(252, 26);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Zen Resource Duplicator";
            // 
            // txtRID
            // 
            this.txtRID.Location = new System.Drawing.Point(118, 93);
            this.txtRID.Name = "txtRID";
            this.txtRID.Size = new System.Drawing.Size(300, 20);
            this.txtRID.TabIndex = 4;
            this.txtRID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRID_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resource ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resource Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lead",
            "Contact"});
            this.comboBox1.Location = new System.Drawing.Point(118, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Checked = true;
            this.rbNo.Location = new System.Drawing.Point(7, 39);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 8;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(49, 39);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(43, 17);
            this.rbYes.TabIndex = 9;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Add A Tag?";
            // 
            // txtNewTag
            // 
            this.txtNewTag.Location = new System.Drawing.Point(95, 38);
            this.txtNewTag.Name = "txtNewTag";
            this.txtNewTag.Size = new System.Drawing.Size(286, 20);
            this.txtNewTag.TabIndex = 11;
            this.txtNewTag.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCurrentTags);
            this.groupBox1.Controls.Add(this.rbNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNewTag);
            this.groupBox1.Controls.Add(this.rbYes);
            this.groupBox1.Location = new System.Drawing.Point(23, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 207);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Tag?";
            // 
            // lblCurrentTags
            // 
            this.lblCurrentTags.AutoSize = true;
            this.lblCurrentTags.Location = new System.Drawing.Point(6, 72);
            this.lblCurrentTags.Name = "lblCurrentTags";
            this.lblCurrentTags.Size = new System.Drawing.Size(55, 13);
            this.lblCurrentTags.TabIndex = 12;
            this.lblCurrentTags.Text = "Waiting ...";
            this.lblCurrentTags.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Resource Name";
            // 
            // lblRName
            // 
            this.lblRName.AutoSize = true;
            this.lblRName.Location = new System.Drawing.Point(115, 124);
            this.lblRName.Name = "lblRName";
            this.lblRName.Size = new System.Drawing.Size(201, 13);
            this.lblRName.TabIndex = 14;
            this.lblRName.Text = "Waiting For Resource ID (Use Enter Key)";
            // 
            // cbOwners
            // 
            this.cbOwners.FormattingEnabled = true;
            this.cbOwners.Location = new System.Drawing.Point(118, 370);
            this.cbOwners.Name = "cbOwners";
            this.cbOwners.Size = new System.Drawing.Size(300, 21);
            this.cbOwners.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "New Owner";
            // 
            // btnGo
            // 
            this.btnGo.Enabled = false;
            this.btnGo.Location = new System.Drawing.Point(20, 400);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(398, 23);
            this.btnGo.TabIndex = 17;
            this.btnGo.Text = "Click To Duplicate";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Enabled = false;
            this.lblLink.Location = new System.Drawing.Point(20, 430);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(16, 13);
            this.lblLink.TabIndex = 18;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "...";
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 455);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cbOwners);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRID);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.debugInstructionsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Zendesk Resource Duplicator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label debugInstructionsLabel;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.TextBox txtRID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewTag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCurrentTags;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRName;
        private System.Windows.Forms.ComboBox cbOwners;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.LinkLabel lblLink;
    }
}

